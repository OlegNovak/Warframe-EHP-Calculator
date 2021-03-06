﻿Imports System.IO
Imports System.Reflection
Imports System.Net
Imports System.Xml.Serialization
Imports System.ComponentModel

Public Class Form_main

    Public assembly As Assembly
    Public localVersion As String
    Public liveVersion As String
    Public Warframes As List(Of Warframe)
    Public Companions As List(Of Companion)
    Public Archwings As List(Of Archwing)
    Public DefaultRankMultipliers As Rank_Multipliers

    '
    ' Fix Laggy Resize Events
    ' Only redraw on end resize
    '
    Private Sub Main_ResizeBegin(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResizeBegin
        SuspendLayout()
    End Sub
    Private Sub Main_ResizeEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResizeEnd
        ResumeLayout()
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.DefaultToMax_warframes = MaxValueToggle_warframes.Checked
        My.Settings.DefaultToMax_companions = MaxValueToggle_compainions.Checked
        My.Settings.DefaultToMax_archwings = MaxValueToggle_archwings.Checked
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assembly = Assembly.GetExecutingAssembly()
        '
        '   This should let the math not explode for non English OS's
        '
        Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.CreateSpecificCulture("en-US")
        '
        ' Version Info
        '
        localVersion = New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.version")).ReadToEnd()
        Text = Text & " (v" & localVersion & ")"
        '
        ' Load Warframe/Companion and Rank Data
        '
        Dim serializer As XmlSerializer
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.DefaultRankMultipliers.xml"))
            serializer = New XmlSerializer(GetType(Rank_Multipliers), New XmlRootAttribute("rank_multipliers"))
            DefaultRankMultipliers = DirectCast(serializer.Deserialize(stream), Rank_Multipliers)
        End Using
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.Warframes.xml"))
            serializer = New XmlSerializer(GetType(List(Of Warframe)), New XmlRootAttribute("warframes"))
            Warframes = DirectCast(serializer.Deserialize(stream), List(Of Warframe)).OrderBy(Function(wf) wf.Name).ToList()
        End Using
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.Companions.xml"))
            serializer = New XmlSerializer(GetType(List(Of Companion)), New XmlRootAttribute("companions"))
            Companions = DirectCast(serializer.Deserialize(stream), List(Of Companion)).OrderBy(Function(c) c.Sort).ThenBy(Function(c) c.Name).ToList()
        End Using
        Using stream As New StreamReader(assembly.GetManifestResourceStream("Warframe_EHP_Calculator_v2.Archwings.xml"))
            serializer = New XmlSerializer(GetType(List(Of Archwing)), New XmlRootAttribute("archwings"))
            Archwings = DirectCast(serializer.Deserialize(stream), List(Of Archwing)).OrderBy(Function(aw) aw.Name).ToList()
        End Using
        For Each warframe As Warframe In Warframes
            ComboBox_warframes.Items.Add(warframe.Name)
        Next
        For Each companion As Companion In Companions
            ComboBox_companions.Items.Add(companion.Name)
        Next
        ComboBox_companions.Items.Remove("Venari")
        For Each archwing As Archwing In Archwings
            ComboBox_archwings.Items.Add(archwing.Name)
        Next
        '
        '   Hide Debug/Dev controls
        '
        TabControl_main.TabPages.Remove(TabPage_development)
        '
        '   Abilities and Arcane Helmets
        '
        For Each Tab As TabPage In TabControl_abilities.TabPages
            For Each Flow As Control In Tab.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    Flow.Visible = False
                    Flow.Parent = CheckedGroupBox_abilities
                End If
            Next
        Next
        FlowLayoutPanel_defaultAbilities.Visible = True
        For Each Tab As TabPage In TabControl_arcaneHelmets.TabPages
            For Each Flow As Control In Tab.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    Flow.Visible = False
                    Flow.Parent = CheckedGroupBox_arcaneHelmets
                End If
            Next
        Next
        FlowLayoutPanel_defaultArcaneHelmets.Visible = True
        '
        '   Change Warframe select box to the default section
        '   also change all other combo boxs to index 0
        '   comboboxs that match index are auto updated by the
        '   event handler
        '
        ComboBox_warframes.SelectedIndex = 0
        ComboBox_companions.SelectedIndex = 0
        ComboBox_archwings.SelectedIndex = 0
        '
        '   UI Update on warframe change - ability and helmet enabling
        '   and recalc EHP on stat change (pretty much everything is linked in here)
        '   Since there are so many things to addHandler for im going to do it at runtime
        '   with loops to make my life easier
        '
        AddHandler ComboBox_warframes.SelectedIndexChanged, AddressOf Warframe_Value_Changed
        AddHandler VariantSelection_warframes.SelectedVariantChanged, AddressOf Warframe_Value_Changed
        For Each Group As Control In FlowLayoutPanel_warframeModsLayout.Controls
            If TypeOf Group Is CheckedGroupBox Then
                Add_Warframe_Handlers(CType(Group, CheckedGroupBox).FlowLayout)
                AddHandler CType(Group, CheckedGroupBox).CheckedChanged, AddressOf Warframe_Value_Changed
            End If
        Next
        '
        '   Companions
        '
        AddHandler ComboBox_companions.SelectedIndexChanged, AddressOf Companion_Value_Changed
        AddHandler VariantSelection_companions.SelectedVariantChanged, AddressOf Companion_Value_Changed
        AddHandler CheckBox_companionPrimeCollar.CheckedChanged, AddressOf Companion_Value_Changed
        AddHandler NumericInput_companionStability.ValueChanged, AddressOf Companion_Value_Changed
        For Each Group As Control In FlowLayoutPanel_compainionModsLayout.Controls
            If TypeOf Group Is CheckedGroupBox Then
                Add_Companion_Handlers(CType(Group, CheckedGroupBox).FlowLayout)
                AddHandler CType(Group, CheckedGroupBox).CheckedChanged, AddressOf Companion_Value_Changed
            End If
        Next
        '
        '   Archwings
        '
        AddHandler ComboBox_archwings.SelectedIndexChanged, AddressOf Archwing_Value_Changed
        AddHandler CheckBox_archwingPrime.CheckedChanged, AddressOf Archwing_Value_Changed
        For Each Group As Control In FlowLayoutPanel_archwingModsLayout.Controls
            If TypeOf Group Is CheckedGroupBox Then
                Add_Archwing_Handlers(CType(Group, CheckedGroupBox).FlowLayout)
                AddHandler CType(Group, CheckedGroupBox).CheckedChanged, AddressOf Archwing_Value_Changed
            End If
        Next
        '
        ' Build Export / Import Buttons
        '
        ' Warframes
        AddHandler Button_warframeImport.Click,
            Sub()
                Dim DefaultExt As String = "wbs"
                Dim Filter As String = "Warframe Builds|*.wfb"
                Dim Title As String = "Import Warframe Build"
                If OpenFileDialog_Import.ShowDialog = DialogResult.OK Then
                    ResetForm.Warframe()
                    BuildSerializor.Deserialize(TabPage_warframe, OpenFileDialog_Import.FileName)
                End If
            End Sub
        AddHandler Button_warframeExport.Click,
            Sub()
                Dim DefaultExt As String = "wfb"
                Dim Filter As String = "Warframe Builds|*.wfb"
                Dim Title As String = "Export Warframe Build"
                Dim FileName As String = ComboBox_warframes.SelectedItem
                If VariantSelection_warframes.SelectedVariant IsNot "base" Then
                    FileName &= " (" & VariantSelection_warframes.SelectedVariant & ")"
                End If
                SaveFileDialog_Export.DefaultExt = DefaultExt
                SaveFileDialog_Export.Filter = Filter
                SaveFileDialog_Export.Title = Title
                SaveFileDialog_Export.FileName = FileName
                If SaveFileDialog_Export.ShowDialog = DialogResult.OK Then
                    BuildSerializor.Serialize(TabPage_warframe, SaveFileDialog_Export.FileName, "Warframe")
                End If
            End Sub
        ' Companions
        AddHandler Button_companionImport.Click,
            Sub()
                Dim DefaultExt As String = "cb"
                Dim Filter As String = "Companion Builds|*.cb"
                Dim Title As String = "Import Companion Build"
                OpenFileDialog_Import.DefaultExt = DefaultExt
                OpenFileDialog_Import.Filter = Filter
                OpenFileDialog_Import.Title = Title
                If OpenFileDialog_Import.ShowDialog = DialogResult.OK Then
                    ResetForm.Companion()
                    BuildSerializor.Deserialize(TabPage_companion, OpenFileDialog_Import.FileName)
                End If
            End Sub
        AddHandler Button_companionExport.Click,
            Sub()
                Dim DefaultExt As String = "cb"
                Dim Filter As String = "Companion Builds|*.cb"
                Dim Title As String = "Export Companion Build"
                Dim FileName As String = ComboBox_companions.SelectedItem
                If VariantSelection_companions.SelectedVariant IsNot "base" Then
                    FileName &= " (" & VariantSelection_companions.SelectedVariant & ")"
                End If
                SaveFileDialog_Export.DefaultExt = DefaultExt
                SaveFileDialog_Export.Filter = Filter
                SaveFileDialog_Export.Title = Title
                SaveFileDialog_Export.FileName = FileName
                If SaveFileDialog_Export.ShowDialog = DialogResult.OK Then
                    BuildSerializor.Serialize(TabPage_companion, SaveFileDialog_Export.FileName, "Warframe")
                End If
            End Sub
        ' Archwings
        AddHandler Button_archwingImport.Click,
            Sub()
                Dim DefaultExt As String = "awb"
                Dim Filter As String = "Archwing Builds|*.awb"
                Dim Title As String = "Import Archwing Build"
                OpenFileDialog_Import.DefaultExt = DefaultExt
                OpenFileDialog_Import.Filter = Filter
                OpenFileDialog_Import.Title = Title
                If OpenFileDialog_Import.ShowDialog = DialogResult.OK Then
                    ResetForm.Archwing()
                    BuildSerializor.Deserialize(TabPage_archwing, OpenFileDialog_Import.FileName)
                End If
            End Sub
        AddHandler Button_archwingExport.Click,
            Sub()
                Dim DefaultExt As String = "awb"
                Dim Filter As String = "Archwing Builds|*.awb"
                Dim Title As String = "Export Archwing Build"
                Dim FileName As String = ComboBox_archwings.SelectedItem
                If CheckBox_archwingPrime.Checked Then
                    FileName &= " (prime)"
                End If
                SaveFileDialog_Export.DefaultExt = DefaultExt
                SaveFileDialog_Export.Filter = Filter
                SaveFileDialog_Export.Title = Title
                SaveFileDialog_Export.FileName = FileName
                If SaveFileDialog_Export.ShowDialog = DialogResult.OK Then
                    BuildSerializor.Serialize(TabPage_archwing, SaveFileDialog_Export.FileName, "Warframe")
                End If
            End Sub
        '
        ' Set Deafult Values to Max
        '
        MaxValueToggle_warframes.Checked = My.Settings.DefaultToMax_warframes
        MaxValueToggle_compainions.Checked = My.Settings.DefaultToMax_companions
        MaxValueToggle_archwings.Checked = My.Settings.DefaultToMax_archwings
        '
        ' Prevent Export Blank Loadout
        '
        Button_warframeExport.Enabled = False
        Button_companionExport.Enabled = False
        Button_archwingExport.Enabled = False
        '
        ' Check for Update
        '
        Try
            Dim WebClient = New WebClient With {
                .CachePolicy = New Cache.RequestCachePolicy(Cache.RequestCacheLevel.NoCacheNoStore)
            }
            Dim gitVersionRaw = WebClient.DownloadString("https://raw.githubusercontent.com/cmd430/Warframe-EHP-Calculator/master/Warframe%20EHP%20Calculator%20v2/version")
            If Format_Version(gitVersionRaw) > Format_Version(localVersion) Then
                ' only show if version is less than released version
                Form_update.ShowDialog()
            End If
        Catch ex As Exception
            'Cant check for updates
        End Try
        Size = New Size(803, 744) ' Window Size = X+13, Y+10
    End Sub

    Private Sub Add_Warframe_Handlers(ByVal ParentControl As Control)
        For Each Control As Control In ParentControl.Controls
            If TypeOf Control Is FlowLayoutPanel Then
                Add_Warframe_Handlers(Control)
            Else
                If TypeOf Control Is CheckedInput Then
                    AddHandler CType(Control, CheckedInput).CheckedChanged, AddressOf Warframe_Value_Changed
                    AddHandler CType(Control, CheckedInput).ValueChanged, AddressOf Warframe_Value_Changed
                ElseIf TypeOf Control Is RadioInput Then
                    AddHandler CType(Control, RadioInput).CheckedChanged, AddressOf Warframe_Value_Changed
                    AddHandler CType(Control, RadioInput).ValueChanged, AddressOf Warframe_Value_Changed
                ElseIf TypeOf Control Is CheckedDualInput Then
                    AddHandler CType(Control, CheckedDualInput).CheckedChanged, AddressOf Warframe_Value_Changed
                    AddHandler CType(Control, CheckedDualInput).ValueChanged, AddressOf Warframe_Value_Changed
                ElseIf TypeOf Control Is NumericInput Then
                    AddHandler CType(Control, NumericInput).ValueChanged, AddressOf Warframe_Value_Changed
                ElseIf TypeOf Control Is CheckBox Then
                    AddHandler CType(Control, CheckBox).CheckedChanged, AddressOf Warframe_Value_Changed
                ElseIf TypeOf Control Is RadioButton Then
                    AddHandler CType(Control, RadioButton).CheckedChanged, AddressOf Warframe_Value_Changed
                End If
            End If
        Next
    End Sub

    Private Sub Add_Companion_Handlers(ByVal ParentControl As Control)
        For Each Control As Control In ParentControl.Controls
            If TypeOf Control Is CheckedInput Then
                AddHandler CType(Control, CheckedInput).CheckedChanged, AddressOf Companion_Value_Changed
                AddHandler CType(Control, CheckedInput).ValueChanged, AddressOf Companion_Value_Changed
            ElseIf TypeOf Control Is RadioInput Then
                AddHandler CType(Control, RadioInput).CheckedChanged, AddressOf Companion_Value_Changed
                AddHandler CType(Control, RadioInput).ValueChanged, AddressOf Companion_Value_Changed
            ElseIf TypeOf Control Is CheckedDualInput Then
                AddHandler CType(Control, CheckedDualInput).CheckedChanged, AddressOf Companion_Value_Changed
                AddHandler CType(Control, CheckedDualInput).ValueChanged, AddressOf Companion_Value_Changed
            ElseIf TypeOf Control Is NumericInput Then
                AddHandler CType(Control, NumericInput).ValueChanged, AddressOf Companion_Value_Changed
            ElseIf TypeOf Control Is CheckBox Then
                AddHandler CType(Control, CheckBox).CheckedChanged, AddressOf Companion_Value_Changed
            ElseIf TypeOf Control Is RadioButton Then
                AddHandler CType(Control, RadioButton).CheckedChanged, AddressOf Companion_Value_Changed
            End If
        Next
    End Sub

    Private Sub Add_Archwing_Handlers(ByVal ParentControl As Control)
        For Each Control As Control In ParentControl.Controls
            If TypeOf Control Is CheckedInput Then
                AddHandler CType(Control, CheckedInput).CheckedChanged, AddressOf Archwing_Value_Changed
                AddHandler CType(Control, CheckedInput).ValueChanged, AddressOf Archwing_Value_Changed
            ElseIf TypeOf Control Is RadioInput Then
                AddHandler CType(Control, RadioInput).CheckedChanged, AddressOf Archwing_Value_Changed
                AddHandler CType(Control, RadioInput).ValueChanged, AddressOf Archwing_Value_Changed
            ElseIf TypeOf Control Is CheckedDualInput Then
                AddHandler CType(Control, CheckedDualInput).CheckedChanged, AddressOf Archwing_Value_Changed
                AddHandler CType(Control, CheckedDualInput).ValueChanged, AddressOf Archwing_Value_Changed
            ElseIf TypeOf Control Is NumericInput Then
                AddHandler CType(Control, NumericInput).ValueChanged, AddressOf Archwing_Value_Changed
            ElseIf TypeOf Control Is CheckBox Then
                AddHandler CType(Control, CheckBox).CheckedChanged, AddressOf Archwing_Value_Changed
            ElseIf TypeOf Control Is RadioButton Then
                AddHandler CType(Control, RadioButton).CheckedChanged, AddressOf Archwing_Value_Changed
            End If
        Next
    End Sub

    Private Function Format_Version(ByVal v As String) As Decimal
        ' remove any whitespace
        v = New String(v.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
        ' if not has a patch number add "-0"
        If v.IndexOf("-") = -1 Then
            v &= "-0"
        End If
        Dim vParts As String() = v.Split("-")
        Dim vMain As String = vParts(0)
        Dim vPatch As String = vParts(1)
        Return vMain & "." & vPatch
    End Function

    Private Sub Warframe_Value_Changed(sender As Object, e As EventArgs)
        '
        '   Default Stats
        '
        Dim baseArmor As Decimal = 0.0
        Dim Armor As Decimal = 0.0
        Dim baseHealth As Decimal = 0.0
        Dim Health As Decimal = 0.0
        Dim baseShield As Decimal = 0.0
        Dim Shield As Decimal = 0.0
        Dim baseEnergy As Decimal = 0.0
        Dim Energy As Decimal = 0.0
        Dim basePowerStrength As Decimal = 0.0
        Dim powerStrength As Decimal = 0.0
        '
        '   Default Multipliers (From Mods)
        '   and bonus added armor
        '
        Dim armorMultiplier As Decimal = 0.0
        Dim healthMultiplier As Decimal = 0.0
        Dim shieldMultiplier As Decimal = 0.0
        Dim energyMultiplier As Decimal = 0.0
        Dim armorBonus As Decimal = 0.0
        Dim healthBonus As Decimal = 0.0
        Dim shieldBonus As Decimal = 0.0
        Dim energyBonus As Decimal = 0.0
        Dim damageReduction As Decimal = 0.0
        '
        '   Sepical Hidden stat for abilities that
        '   100% absorb x amount dmg
        '
        Dim damageAbsorbstion As Decimal = 0.0
        If ComboBox_warframes.SelectedIndex > 0 Then
            Dim currentWarframe As Warframe = Warframes.Find(Function(wf) wf.Name = ComboBox_warframes.SelectedItem)
            Dim hasPrime As Boolean = Not currentWarframe.Variants.Find(Function(var) var.Name = "prime") Is Nothing
            Dim hasUmbra As Boolean = Not currentWarframe.Variants.Find(Function(var) var.Name = "umbra") Is Nothing
            '
            '   Does the frame have a Prime or Umbra version ?
            '   if so we can enable to checkbox
            '
            If hasPrime And hasUmbra Then
                VariantSelection_warframes.AvailableVariants = "prime_umbra"
            ElseIf hasPrime Then
                VariantSelection_warframes.AvailableVariants = "prime"
            ElseIf hasUmbra Then
                VariantSelection_warframes.AvailableVariants = "umbra"
            Else
                VariantSelection_warframes.AvailableVariants = "base"
            End If
            '
            '   Special Modifiers
            '
            '   some frames have passives that change fixed things
            '
            If currentWarframe.Name = "Khora" And Not ComboBox_companions.Items.Contains("Venari") Then
                ComboBox_companions.Items.Insert(3, "Venari")
            ElseIf Not currentWarframe.Name = "Khora" And ComboBox_companions.Items.Contains("Venari") Then
                If ComboBox_companions.SelectedItem = "Venari" Then
                    ComboBox_companions.SelectedIndex = 0
                End If
                ComboBox_companions.Items.Remove("Venari")
            End If
            If currentWarframe.Name = "Harrow" Then
                CheckedInput_overshields.Maximum = 2400
                If MaxValueToggle_warframes.Checked Then
                    CheckedInput_overshields.Value = CheckedInput_overshields.Maximum
                End If
            Else
                CheckedInput_overshields.Maximum = 1200
                If MaxValueToggle_warframes.Checked Then
                    CheckedInput_overshields.Value = CheckedInput_overshields.Maximum
                End If
            End If
            '
            '  Enable/Disable Arcane Helmets selection
            '
            FlowLayoutPanel_defaultArcaneHelmets.Visible = True
            For Each Flow As Control In CheckedGroupBox_arcaneHelmets.FlowLayout.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    If Not Flow.Name.Contains("default") Then
                        If Not Flow.Name.Contains(currentWarframe.Name.ToLower) Then
                            Flow.Visible = False
                        Else
                            Flow.Visible = True
                            FlowLayoutPanel_defaultArcaneHelmets.Visible = False
                        End If
                    End If
                End If
            Next
            '
            '   Enable/Disable Abilities Selection
            '
            FlowLayoutPanel_defaultAbilities.Visible = True
            For Each Flow As Control In CheckedGroupBox_abilities.FlowLayout.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    If Not Flow.Name.Contains("default") Then
                        If Not Flow.Name.Contains(currentWarframe.Name.ToLower) Then
                            Flow.Visible = False
                        Else
                            Flow.Visible = True
                            FlowLayoutPanel_defaultAbilities.Visible = False
                        End If
                    End If
                End If
            Next
            '
            ' Base Stats
            '
            Dim currentVariant As [Variant] = currentWarframe.Variants.Find(Function(var) var.Name = VariantSelection_warframes.SelectedVariant)
            baseArmor = currentVariant.Armor
            baseHealth = currentVariant.Health
            baseShield = currentVariant.Shield
            baseEnergy = currentVariant.Energy
            basePowerStrength = currentVariant.strength / 100
            '
            ' Syndicate buffs (Modifiy Base Stats)
            '
            If CheckBox_cepholonSudaBuff.Checked Then
                baseEnergy *= 1.25
            End If
            If CheckBox_newLokaBuff.Checked Then
                baseHealth *= 1.25
            End If
            If CheckBox_perrinSequenceBuff.Checked Then
                baseShield *= 1.5
            End If
            If CheckBox_steelMeridianBuff.Checked Then
                baseArmor *= 1.15
            End If
            '
            ' Rank 30 Stats
            '
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "armor") Is Nothing Then
                Armor = baseArmor * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "armor").Multiplier
            Else
                Armor = baseArmor * DefaultRankMultipliers.Warframes.Find(Function(m) m.Name = "armor").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "health") Is Nothing Then
                Health = baseHealth * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "health").Multiplier
            Else
                Health = baseHealth * DefaultRankMultipliers.Warframes.Find(Function(m) m.Name = "health").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "shield") Is Nothing Then
                Shield = baseShield * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "shield").Multiplier
            Else
                Shield = baseShield * DefaultRankMultipliers.Warframes.Find(Function(m) m.Name = "shield").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "energy") Is Nothing Then
                Energy = baseEnergy * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "energy").Multiplier
            Else
                Energy = baseEnergy * DefaultRankMultipliers.Warframes.Find(Function(m) m.Name = "energy").Multiplier
            End If
            If Not currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "strength") Is Nothing Then
                powerStrength = basePowerStrength * currentWarframe.Rank_Multipliers.Find(Function(rm) rm.Name = "strength").Multiplier
            Else
                powerStrength = basePowerStrength * DefaultRankMultipliers.Warframes.Find(Function(m) m.Name = "strength").Multiplier
            End If
            '
            ' Overshields
            '
            If CheckedGroupBox_specialEffects.Checked And CheckedInput_overshields.Checked Then
                shieldBonus += CheckedInput_overshields.Value
            End If
            '
            '   Arcane Helmets
            '
            If CheckedGroupBox_arcaneHelmets.Checked Then
                Select Case currentWarframe.Name
                    Case "Ash"
                        If RadioButton_locustHelmet.Checked Then
                            Energy += baseEnergy * 0.2
                        End If
                    Case "Banshee"
                        If RadioButton_reverbHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Energy += baseEnergy * 0.1
                        End If
                    Case "Ember"
                        If RadioButton_phoenixHelmet.Checked Then
                            Shield += baseShield * 0.05
                            Energy += baseEnergy * 0.25
                        ElseIf RadioButton_backdraftHelmet.Checked Then
                            Health += baseHealth * 0.15
                        End If
                    Case "Excalibur"
                        If RadioButton_avalonHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Shield += baseShield * 0.25
                        ElseIf RadioButton_pendragonHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                            powerStrength += powerStrength * 0.15
                        End If
                    Case "Frost"
                        If RadioButton_auroraHelmet.Checked Then
                            Health -= baseHealth * 0.05
                            Armor += baseArmor * 0.25
                        ElseIf RadioButton_squallHelmet.Checked Then
                            Shield -= baseShield * 0.05
                            powerStrength += powerStrength * 0.15
                        End If
                    Case "Loki"
                        If RadioButton_essenceHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                        ElseIf RadioButton_swindleHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Mag"
                        If RadioButton_coilHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_gaussHelmet.Checked Then
                            Energy += baseEnergy * 0.25
                        End If
                    Case "Nova"
                        If RadioButton_fluxHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Nyx"
                        If RadioButton_menticideHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_vespaHelmet.Checked Then
                            Armor -= baseArmor * 0.05
                        End If
                    Case "Rhino"
                        If RadioButton_thrak.Checked Then
                            Health += baseHealth * 0.25
                        ElseIf RadioButton_vanguardHelmet.Checked Then
                            powerStrength -= powerStrength * 0.05
                        End If
                    Case "Saryn"
                        If RadioButton_hemlockHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        End If
                    Case "Trinity"
                        If RadioButton_auraHelmet.Checked Then
                            Health -= baseHealth * 0.05
                        ElseIf RadioButton_meridianHelmet.Checked Then
                            Shield += baseShield * 0.15
                        End If
                    Case "Vauban"
                        If RadioButton_espritHelmet.Checked Then
                            Shield -= baseShield * 0.1
                            Energy += baseEnergy * 0.1
                        End If
                    Case "Volt"
                        If RadioButton_pulseHelmet.Checked Then
                            Shield -= baseShield * 0.05
                        ElseIf RadioButton_stormHelmet.Checked Then
                            powerStrength += powerStrength * 0.1
                        End If
                End Select
            End If
            '
            '   Mission Modifiers
            '
            If CheckedGroupBox_missionModifiers.Checked Then
                If RadioButton_missionCryogenicLeakage.Checked Then
                    Shield -= baseShield * 0.5
                ElseIf RadioButton_missionFire.Checked Then
                    Health -= baseHealth * 0.5
                End If
            End If
            '
            '   Aura Mods
            '
            If CheckedGroupBox_aura.Checked Then
                If RadioInput_physique.Checked Then
                    Dim physique As Decimal = 0.15 + (RadioInput_physique.Value * 0.15)
                    If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                        '
                        '   Coaction Drift is Strange, it gives you a 0.15 boost to all Auras
                        '   and another 0.15 boost to your Aura ontop of the other for a total
                        '   of 0.15 * (1 + 0.15) + 0.15 = 0.3225 (values are for max rank mod)
                        '
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                        healthMultiplier += physique + (physique * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        healthMultiplier += physique
                    End If
                ElseIf RadioInput_standUnited.Checked Then
                    Dim standUnited As Decimal = 0.0425 + (RadioInput_standUnited.Value * 0.0425)
                    If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                        armorMultiplier += standUnited + (standUnited * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        armorMultiplier += standUnited
                    End If
                ElseIf RadioInput_growingPower.Checked Then
                    Dim growingPower As Decimal = basePowerStrength * (0.04166666667 + (RadioInput_growingPower.Value * 0.04166666667))
                    'If CheckBox_coactionDrift.Checked And CheckBox_miscellaneous.Checked Then
                    'Dim coactionDrit As Decimal = 0.025 + (0.025 * NumericUpDown_coactionDrift.Value)
                    'powerStrength = powerStrength + (growingPower + (growingPower * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                    'Else
                    powerStrength += growingPower
                    ' End If
                ElseIf RadioInput_powerDonation.Checked Then
                    'Note: Power Donation does not seem to be affected by co-action drift at this time.
                    Dim powerDonation As Decimal = basePowerStrength * (0.05 + (RadioInput_powerDonation.Value * 0.05))
                    powerStrength -= powerDonation
                ElseIf RadioInput_aerodynamic.Checked Then
                    If CheckBox_airborne.Checked And CheckedGroupBox_specialEffects.Checked Then
                        Dim aerodynamic As Decimal = 0.04 + (RadioInput_aerodynamic.Value * 0.04)
                        If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                            Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                            damageReduction += (1 - damageReduction) * (aerodynamic + (aerodynamic * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                        Else
                            damageReduction += (1 - damageReduction) * aerodynamic
                        End If
                    End If
                End If
            End If
            '
            '   Armor / Health / Shield / Damage Reduction Mods
            '
            If CheckedGroupBox_survivability.Checked Then
                ' armor
                If CheckedInput_steelFiber.Checked Then
                    armorMultiplier += 0.1 + (CheckedInput_steelFiber.Value * 0.1)
                End If
                If CheckedInput_armoredAgility.Checked Then
                    armorMultiplier += 0.075 + (CheckedInput_armoredAgility.Value * 0.075)
                End If
                If CheckedDualInput_healthConversion.Checked Then
                    armorBonus += (75 + (CheckedDualInput_healthConversion.Value * 75)) * CheckedDualInput_healthConversion.Secondary_Value
                End If
                If CheckedInput_gladiatorAegis.Checked Then
                    armorMultiplier += 0.075 + (CheckedInput_gladiatorAegis.Value * 0.075)
                End If
                If CheckedInput_focusedDefense.Checked Then
                    armorMultiplier += 0.05 + (CheckedInput_focusedDefense.Value * 0.05)
                End If
                If CheckedDualInput_mechaPulse.Checked Then
                    armorMultiplier += (0.15 + (CheckedDualInput_mechaPulse.Value * 0.15)) * (1 + CheckedDualInput_mechaPulse.Secondary_Value)
                End If
                ' health
                If CheckedInput_vitality.Checked Then
                    healthMultiplier += 0.4 + (CheckedInput_vitality.Value * 0.4)
                End If
                If CheckedInput_gladiatorResolve.Checked Then
                    healthMultiplier += 0.3 + (CheckedInput_gladiatorResolve.Value * 0.3)
                End If
                ' quickthinking moved.
                ' gladiator finesse moved.
                ' shields
                If CheckedInput_redirection.Checked Then
                    shieldMultiplier += 0.4 + (CheckedInput_redirection.Value * 0.4)
                End If
                If CheckedInput_augurAccord.Checked Then
                    shieldMultiplier += 0.3 + (CheckedInput_augurAccord.Value * 0.3)
                End If
                'dual
                If CheckedInput_vigor.Checked Then
                    healthMultiplier += 0.2 + (CheckedInput_vigor.Value * 0.2)
                    shieldMultiplier += 0.2 + (CheckedInput_vigor.Value * 0.2)
                End If
                ' damage reduction
                If CheckBox_airborne.Checked And CheckedGroupBox_specialEffects.Checked Then
                    If CheckedInput_agilityDrift.Checked And Not CheckedInput_aviator.Checked And Not RadioInput_aerodynamic.Checked Then
                        Dim agilityDrift As Decimal = 0.02 + (CheckedInput_agilityDrift.Value * 0.02)
                        damageReduction += (1 - damageReduction) * agilityDrift
                    End If
                    If CheckedInput_aviator.Checked And Not CheckedInput_agilityDrift.Checked And Not RadioInput_aerodynamic.Checked Then
                        Dim aviator As Decimal = 0.1 + (CheckedInput_aviator.Value * 0.1)
                        damageReduction += (1 - damageReduction) * aviator
                    End If
                    If CheckedInput_aviator.Checked Or CheckedInput_agilityDrift.Checked Or RadioInput_aerodynamic.Checked Then
                        Dim aerodynamic As Decimal = 0.04 + (RadioInput_aerodynamic.Value * 0.04)
                        If CheckedInput_coactionDrift.Checked And CheckedGroupBox_miscellaneous.Checked Then
                            Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_coactionDrift.Value)
                            aerodynamic = (aerodynamic + (aerodynamic * (coactionDrit * (1 + coactionDrit) + coactionDrit)))
                        End If
                        Dim agilityDrift As Decimal = 0.02 + (CheckedInput_agilityDrift.Value * 0.02)
                        Dim aviator As Decimal = 0.1 + (CheckedInput_aviator.Value * 0.1)

                        If CheckedInput_aviator.Checked And CheckedInput_agilityDrift.Checked And RadioInput_aerodynamic.Checked And CheckedGroupBox_aura.Checked Then
                            ' all 3
                            damageReduction = aviator + agilityDrift + aerodynamic
                        ElseIf CheckedInput_aviator.Checked And CheckedInput_agilityDrift.Checked Then
                            ' 2 non aura
                            damageReduction = aviator + agilityDrift
                        ElseIf CheckedInput_aviator.Checked And RadioInput_aerodynamic.Checked And CheckedGroupBox_aura.Checked Then
                            ' 1 non aua + aura
                            damageReduction = aviator + aerodynamic
                        ElseIf CheckedInput_agilityDrift.Checked And RadioInput_aerodynamic.Checked And CheckedGroupBox_aura.Checked Then
                            ' 1 non aua + aura
                            damageReduction = agilityDrift + aerodynamic
                        End If
                    End If

                    If Shield > 0 Then
                        If damageReduction > 0 Then ' additivly stack with aerodynamic mods
                            damageReduction += 0.25
                        End If
                    End If
                End If
                If CheckedInput_protonSet.Checked Then
                    Dim protonSet As Decimal = CheckedInput_protonSet.Value * 0.165
                    damageReduction += (1 - damageReduction) * protonSet
                End If
                If CheckBox_adaptation.Checked Then
                        Dim adaptation As Decimal = 0.9
                        damageReduction += (1 - damageReduction) * adaptation
                    End If
                End If
                '
                '   Energy Mods
                '
                If CheckedGroupBox_miscellaneous.Checked Then
                If CheckedInput_enduranceDrift.Checked Then
                    energyMultiplier += 0.025 + (CheckedInput_enduranceDrift.Value * 0.025)
                End If
                If CheckedInput_flow.Checked Then
                    energyMultiplier += 0.25 + (CheckedInput_flow.Value * 0.25)
                End If
            End If
            '
            '   Power Strength Mods
            '
            If CheckedGroupBox_powerStrength.Checked Then
                If CheckedInput_overextended.Checked Then
                    powerStrength -= basePowerStrength * (0.1 + (CheckedInput_overextended.Value * 0.1))
                End If
                If CheckedInput_blindRage.Checked Then
                    powerStrength += basePowerStrength * (0.09 + (CheckedInput_blindRage.Value * 0.09))
                End If
                If CheckedInput_energyConversion.Checked Then
                    powerStrength += basePowerStrength * (0.08333333333 + (CheckedInput_energyConversion.Value * 0.08333333333))
                End If
                If CheckedInput_intensify.Checked Then
                    powerStrength += basePowerStrength * (0.05 + (CheckedInput_intensify.Value * 0.05))
                End If
                If CheckedInput_transientFortitude.Checked Then
                    powerStrength += basePowerStrength * (0.05 + (CheckedInput_transientFortitude.Value * 0.05))
                End If
                If CheckedInput_powerDrift.Checked Then
                    powerStrength += basePowerStrength * (0.025 + (CheckedInput_powerDrift.Value * 0.025))
                End If
                If CheckedInput_augurSecrets.Checked Then
                    powerStrength += basePowerStrength * (0.04 + (CheckedInput_augurSecrets.Value * 0.04))
                End If
            End If
            '
            '   Umbral Mods
            '
            Dim UmbralModifiy As Integer = 0
            If CheckedGroupBox_survivability.Checked Then
                If CheckedInput_umbralFiber.Checked Then
                    UmbralModifiy += 1
                End If
                If CheckedInput_umbralVitality.Checked Then
                    UmbralModifiy += 1
                End If
            End If
            If CheckedGroupBox_powerStrength.Checked And CheckedInput_umbralIntensify.Checked Then
                UmbralModifiy += 1
            End If
            If CheckedGroupBox_survivability.Checked Then
                'Armor
                If CheckedInput_umbralFiber.Checked Then
                    If UmbralModifiy = 1 Then
                        armorMultiplier += 0.1 + (CheckedInput_umbralFiber.Value * 0.1)
                    ElseIf UmbralModifiy = 2 Then
                        armorMultiplier += 0.125 + (CheckedInput_umbralFiber.Value * 0.125)
                    ElseIf UmbralModifiy = 3 Then
                        armorMultiplier += 0.175 + (CheckedInput_umbralFiber.Value * 0.175)
                    End If
                End If
                'Health
                If CheckedInput_umbralVitality.Checked Then
                    If UmbralModifiy = 1 Then
                        healthMultiplier += 0.4 + (CheckedInput_umbralVitality.Value * 0.4)
                    ElseIf UmbralModifiy = 2 Then
                        healthMultiplier += 0.5 + (CheckedInput_umbralVitality.Value * 0.5)
                    ElseIf UmbralModifiy = 3 Then
                        healthMultiplier += 0.7 + (CheckedInput_umbralVitality.Value * 0.7)
                    End If
                End If
            End If
            If CheckedGroupBox_powerStrength.Checked Then
                'Power
                If CheckedInput_umbralIntensify.Checked Then
                    If UmbralModifiy = 1 Then
                        powerStrength += basePowerStrength * (0.04 + (CheckedInput_umbralIntensify.Value * 0.04))
                    ElseIf UmbralModifiy = 2 Then
                        powerStrength += basePowerStrength * (0.05 + (CheckedInput_umbralIntensify.Value * 0.05))
                    ElseIf UmbralModifiy = 3 Then
                        powerStrength += basePowerStrength * (0.06 + (CheckedInput_umbralIntensify.Value * 0.06))
                    End If
                End If
            End If
            '
            '   Special Buffs
            '
            If CheckedGroupBox_specialEffects.Checked Then
                ' Corrupted
                If CheckBox_corruptedBuff.Checked Then
                    powerStrength *= 2
                End If
                ' Arbitration
                If CheckBox_arbitrationBuff.Checked Then
                    powerStrength += 3
                End If
                If CheckBox_airborne.Checked Then
                    If damageReduction > 0.9 Then
                        damageReduction = 0.9
                    End If
                End If
            End If
            '
            ' Shield DR
            '
            If Shield > 0 Then
                If Not CheckBox_airborne.Checked Or Not CheckedGroupBox_specialEffects.Checked Then
                    damageReduction += (1 - damageReduction) * 0.25
                Else
                    If damageReduction = 0 Then
                        damageReduction += (1 - damageReduction) * 0.25
                    End If
                End If
            End If
            '
            '   Abilities
            '
            '   +Special Ember Effect
            '   +Pax Bolt
            '
            Dim immolation_min As Decimal = 0.4 * powerStrength
            CheckedInput_immolation.Minimum = If(immolation_min > 0.5, 0.5, immolation_min) * 100
            Dim immolation_max As Decimal = 0.85 * powerStrength
            CheckedInput_immolation.Maximum = If(immolation_max > 0.9, 0.9, immolation_max) * 100
            If CheckedGroupBox_arcanes.Checked Then
                If CheckedInput_arcanePaxBolt.Checked Then
                    powerStrength += 0.075 + (0.075 * CheckedInput_arcanePaxBolt.Value)
                End If
            End If
            '
            If CheckedGroupBox_abilities.Checked Then
                Select Case currentWarframe.Name
                    Case "Atlas"
                        If CheckedInput_rubble.Checked Then
                            Dim rubble As Decimal = CheckedInput_rubble.Value
                            armorBonus += rubble
                        End If
                    Case "Baruuk"
                        Dim restraint As Decimal = 0.5 * (1 - (CheckedInput_restraint.Value / 100))
                        Dim desolateHands As Decimal = 0.8 * powerStrength
                        If desolateHands > 0.9 Then
                            desolateHands = 0.9
                        End If
                        Dim sereneStorm As Decimal = 0.25 * powerStrength
                        If sereneStorm > 0.4 Then
                            sereneStorm = 0.4
                        End If
                        If CheckedInput_restraint.Checked Then
                            damageReduction += (1 - damageReduction) * restraint
                        End If
                        If CheckBox_desolateHands.Checked Then
                            damageReduction += (1 - damageReduction) * desolateHands
                        End If
                        If CheckBox_sereneStorm.Checked Then
                            damageReduction += (1 - damageReduction) * sereneStorm
                        End If
                    Case "Chroma"
                        If CheckBox_elementalWard.Checked Then
                            Dim elementalWard As Decimal = 0.0
                            If RadioButton_iceChroma.Checked Then
                                elementalWard = 1.5 * powerStrength
                                armorMultiplier += elementalWard
                            ElseIf RadioButton_fireChroma.Checked Then
                                elementalWard = 2.0 * powerStrength
                                healthMultiplier += elementalWard
                            ElseIf RadioButton_electricChroma.Checked Then
                                elementalWard = 1.0 * powerStrength
                                shieldMultiplier += elementalWard
                            End If
                        End If
                        If CheckBox_vexArmor.Checked And currentWarframe.Name = "Chroma" And CheckedGroupBox_abilities.Checked Then
                            Dim vexArmor As Decimal = 3.5 * powerStrength
                            armorMultiplier += vexArmor
                        End If
                    Case "Ember"
                        If CheckedInput_conflagration.Checked Then
                            Dim conflagration As Decimal = 0.05 * CheckedInput_conflagration.Value
                            powerStrength += conflagration
                        End If
                        If CheckedInput_immolation.Checked Then
                            damageReduction += (1 - damageReduction) * (CheckedInput_immolation.Value / 100)
                        End If
                    Case "Excalibur"
                        If CheckBox_exaltedBlade.Checked Then
                            Dim exaltedBlade As Decimal = 0.6
                            damageReduction += (1 - damageReduction) * exaltedBlade
                        End If
                    Case "Frost"
                        If CheckedInput_icyAvalanche.Checked Then
                            Dim icyAvalance As Decimal = 0.6 * powerStrength * CheckedInput_icyAvalanche.Value
                            damageReduction += (1 - damageReduction) * icyAvalance
                        End If
                    Case "Gara"
                        If CheckBox_splinterStorm.Checked Then
                            Dim splinterStorm As Decimal = 0.7 * powerStrength
                            If splinterStorm > 0.9 Then
                                splinterStorm = 0.9
                            End If
                            damageReduction += (1 - damageReduction) * splinterStorm
                        End If
                    Case "Grendel"
                        If CheckedInput_glutton.Checked Then
                            armorBonus += 50 * CheckedInput_glutton.Value
                        End If
                    Case "Harrow"
                        If CheckBox_wardingThurible.Checked Then
                            Dim wardingThurible As Decimal = 0.4 * powerStrength
                            If wardingThurible > 0.9 Then
                                wardingThurible = 0.9
                            End If
                            damageReduction += (1 - damageReduction) * wardingThurible
                        End If
                    Case "Inaros"
                        If CheckedInput_scarabSwarm.Checked Then
                            Dim scarabSwarm As Decimal = 2 * CheckedInput_scarabSwarm.Value
                            armorBonus += scarabSwarm
                        End If
                    Case "Mesa"
                        If CheckBox_shatterShield.Checked Then
                            Dim shatterShield As Decimal = 0.8 * powerStrength
                            If shatterShield > 0.95 Then
                                shatterShield = 0.95
                            End If
                            damageReduction += (1 - damageReduction) * shatterShield
                        End If
                        If CheckBox_marksmansDexterity.Checked Then
                            healthBonus += 50
                        End If
                    Case "Mirage"
                        If CheckBox_eclipse.Checked Then
                            Dim eclipse As Decimal = 0.75 * powerStrength
                            If eclipse > 0.95 Then
                                eclipse = 0.95
                            End If
                            damageReduction += (1 - damageReduction) * eclipse
                        End If
                    Case "Nekros"
                        If CheckedInput_shieldOfShadows.Checked Then
                            Dim shieldOfShadows As Decimal = 0.06 * powerStrength * CheckedInput_shieldOfShadows.Value
                            If shieldOfShadows > 0.9 Then
                                shieldOfShadows = 0.9
                            End If
                            damageReduction += (1 - damageReduction) * shieldOfShadows
                        End If
                    Case "Nezha"
                        If CheckBox_wardingHalo.Checked Then
                            Dim wardingHalo As Decimal = 0.9
                            damageReduction += (1 - damageReduction) * wardingHalo
                        End If
                    Case "Nidus"
                        If CheckBox_parasiticLink.Checked Then
                            Dim parasiticLink As Decimal = 0.5 * powerStrength
                            If parasiticLink > 0.9 Then
                                parasiticLink = 0.9
                            End If
                            damageReduction += (1 - damageReduction) * parasiticLink
                        End If
                    Case "Nova"
                        If CheckedInput_nullStar.Checked Then
                            Dim particles As Decimal = CheckedInput_nullStar.Value
                            Dim nullStar As Decimal = 0.05 * particles
                            If nullStar > 0.9 Then
                                nullStar = 0.9
                            End If
                            damageReduction += (1 - damageReduction) * nullStar
                        End If
                    Case "Oberon"
                        If CheckBox_ironRenewal.Checked Then
                            Dim ironRenewal As Decimal = 200 * powerStrength
                            armorBonus += ironRenewal
                        End If
                        If CheckBox_hallowedReckoning.Checked Then
                            Dim hallowedReckoning As Decimal = 250
                            armorBonus += hallowedReckoning
                        End If
                    Case "Octavia"
                        If CheckBox_metronome.Checked Then
                            Dim metronome As Decimal = 0.35 * powerStrength
                            armorMultiplier += metronome
                        End If
                    Case "Rhino"
                        If CheckedInput_ironcladCharge.Checked Then
                            Dim ironcladCharge As Decimal = 0.5 * powerStrength * CheckedInput_ironcladCharge.Value
                            armorMultiplier += ironcladCharge
                        End If
                        If CheckedInput_ironSkin.Checked Then
                            Dim ironSkinArmor As Decimal = 2.5 * Armor * (1 + armorMultiplier)
                            Dim ironSkinHealth As Decimal = 1200
                            Dim ironSkin As Decimal = ((ironSkinHealth + ironSkinArmor) * powerStrength) + CheckedInput_ironSkin.Value
                            damageAbsorbstion += ironSkin
                        End If
                    Case "Titania"
                        If CheckBox_thorns.Checked Then
                            Dim thorns As Decimal = 0.5
                            damageReduction += (1 - damageReduction) * thorns
                        End If
                    Case "Trinity"
                        Dim link As Decimal = 0.75
                        Dim blessing As Decimal = 0.5 * powerStrength
                        If blessing > 0.75 Then
                            blessing = 0.75
                        End If
                        If CheckBox_link.Checked And Not CheckBox_blessing.Checked Then
                            damageReduction += (1 - damageReduction) * link
                        ElseIf CheckBox_blessing.Checked And Not CheckBox_link.Checked Then
                            damageReduction += (1 - damageReduction) * blessing
                        ElseIf CheckBox_link.Checked And CheckBox_blessing.Checked Then
                            damageReduction += blessing + ((1 - blessing) * link)
                        End If
                    Case "Valkyr"
                        If CheckBox_warcry.Checked Then
                            Dim warcryMultiplier As Decimal = 0.5 * powerStrength
                            armorMultiplier += warcryMultiplier
                        End If
                    Case "Vauban"
                        If CheckedInput_bastille.Checked Then
                            armorBonus += CheckedInput_bastille.Value
                        End If
                    Case "Wisp"
                        If CheckBox_vitalityMoteReservoirs.Checked Then
                            Dim vitalityMoteBonus As Decimal = 300 * powerStrength
                            healthBonus += vitalityMoteBonus
                        End If
                    Case "Wukong"
                        If CheckedInput_defy.Checked Then
                            Dim defy As Decimal = CheckedInput_defy.Value
                            armorBonus += defy
                        End If
                End Select
            End If
            '
            '   Calculate Values (with special support for Quickthinking and Gladiator Finesse)
            '
            Armor = (baseArmor * (1 + armorMultiplier)) + (Armor - baseArmor) + armorBonus
            Energy = Math.Ceiling(Energy) + Math.Floor((baseEnergy * energyMultiplier) + energyBonus)
            If CheckedGroupBox_survivability.Checked Then
                If CheckedInput_quickThinking.Checked Then
                    healthBonus += 0.4 * (1 + CheckedInput_quickThinking.Value) * Energy
                End If
                If CheckedInput_gladiatorFinesse.Checked Then
                    healthBonus += 0.1 * (1 + CheckedInput_gladiatorFinesse.Value) * Energy
                End If
            End If
            Health = (baseHealth * (1 + healthMultiplier)) + (Health - baseHealth) + healthBonus
            Shield = (baseShield * (1 + shieldMultiplier)) + (Shield - baseShield) + shieldBonus
            '
            '   Arcanes
            '
            If CheckedGroupBox_arcanes.Checked Then
                '
                '   Arcane Effects
                '
                If CheckedInput_arcaneGuardian.Checked Then
                    Armor += 150 + (150 * CheckedInput_arcaneGuardian.Value)
                End If
                If CheckedInput_arcaneUltimatum.Checked Then
                    Armor += 200 + (200 * CheckedInput_arcaneUltimatum.Value)
                End If
                If CheckedInput_arcaneTanker.Checked Then
                    Armor += 200 + (200 * CheckedInput_arcaneUltimatum.Value)
                End If
            End If
            '
            '   Focus
            '
            If CheckedGroupBox_focus.Checked And CheckedInput_stoneSkin.Checked Then
                ' Memes (Fibonacci Squence - first 2 numbers)
                Armor = Armor + 10 + 1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, CheckedInput_stoneSkin.Value + 2) - Math.Pow((1 - Math.Sqrt(5)) / 2, CheckedInput_stoneSkin.Value + 2)) * 10
            End If
            '
            '   Dragon Keys
            '
            If CheckedGroupBox_dragonKeys.Checked Then
                If CheckBox_bleedingKey.Checked Then
                    Health *= 0.25
                End If
                If CheckBox_decayingKey.Checked Then
                    Shield *= 0.25
                End If
            End If
            StatBox_warframeArmor.Value = Armor
            StatBox_warframeHealth.Value = Health
            StatBox_warframeShield.Value = Shield
            StatBox_warframeEnergy.Value = Energy
            StatBox_warframePowerStrength.Value = powerStrength * 100
            StatBox_warframeDamageReduction.Value = damageReduction * 100
            '
            '   sheild dr
            '
            'Shield = Shield * (4 / 3) old way
            '
            '   Calculate EHP
            '
            Dim damageReductionArmor As Decimal = Armor / (300 + Armor)
            Dim totalDamageReduction As Decimal = damageReductionArmor + ((1 - damageReductionArmor) * damageReduction)
            'Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield + damageAbsorbstion))
            Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield / (1 - damageReduction)) + damageAbsorbstion)
            StatBox_warframeEHP.Value = effectiveHealth
            '
            ' Enable Export of Build
            '
            Button_warframeExport.Enabled = True
        Else
            '
            '   No Warframe selected, display values should be set to default
            '
            StatBox_warframeArmor.Value = Nothing
            StatBox_warframeHealth.Value = Nothing
            StatBox_warframeShield.Value = Nothing
            StatBox_warframeEnergy.Value = Nothing
            StatBox_warframePowerStrength.Value = Nothing
            StatBox_warframeEHP.Value = Nothing
            StatBox_warframeDamageReduction.Value = Nothing
            FlowLayoutPanel_defaultArcaneHelmets.Visible = True
            For Each Flow As Control In CheckedGroupBox_arcaneHelmets.FlowLayout.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    If Not Flow.Name.Contains("default") Then
                        Flow.Visible = False
                    End If
                End If
            Next
            FlowLayoutPanel_defaultAbilities.Visible = True
            For Each Flow As Control In CheckedGroupBox_abilities.FlowLayout.Controls
                If TypeOf Flow Is FlowLayoutPanel Then
                    If Not Flow.Name.Contains("default") Then
                        Flow.Visible = False
                    End If
                End If
            Next
            '
            ' Disable Export of Build
            '
            Button_warframeExport.Enabled = False
        End If
        Companion_Value_Changed(sender, e)
    End Sub

    Private Sub Companion_Value_Changed(sender As Object, e As EventArgs)
        Dim currentWarframe As Warframe = Warframes.Find(Function(wf) wf.Name = ComboBox_warframes.SelectedItem)
        Dim currentCompanion As Companion = Companions.Find(Function(c) c.Name = ComboBox_companions.SelectedItem)
        '   Pet Stats
        Dim baseArmor As Decimal = 0.0
        Dim Armor As Decimal = 0.0
        Dim baseHealth As Decimal = 0.0
        Dim Health As Decimal = 0.0
        Dim baseShield As Decimal = 0.0
        Dim Shield As Decimal = 0.0
        '   mods
        Dim armorMultiplier As Decimal = 0.0
        Dim healthMultiplier As Decimal = 0.0
        Dim shieldMultiplier As Decimal = 0.0
        Dim armorBonus As Decimal = 0.0
        Dim healthBonus As Decimal = 0.0
        Dim shieldBonus As Decimal = 0.0
        Dim energyBonus As Decimal = 0.0
        Dim damageReduction As Decimal = 0.0

        If currentCompanion IsNot Nothing Then
            Dim hasPrime As Boolean = Not currentCompanion.Variants.Find(Function(var) var.Name = "prime") Is Nothing
            Dim hasPrisma As Boolean = Not currentCompanion.Variants.Find(Function(var) var.Name = "prisma") Is Nothing
            '
            '   Does the companion have a Prime or Prisma version ?
            '   if so we can enable to checkbox
            '
            If hasPrime And hasPrisma Then
                VariantSelection_companions.AvailableVariants = "prime_prisma"
            ElseIf hasPrime Then
                VariantSelection_companions.AvailableVariants = "prime"
            ElseIf hasPrisma Then
                VariantSelection_companions.AvailableVariants = "prisma"
            Else
                VariantSelection_companions.AvailableVariants = "base"
            End If
            If currentCompanion.Type = "kubrow" Or currentCompanion.Type = "helminth" Then
                CheckBox_companionPrimeCollar.Enabled = True
            Else
                CheckBox_companionPrimeCollar.Enabled = False
            End If
            If currentCompanion.Type = "sentinel" Then
                CheckedInput_companionLinkArmor.Visible = False
                CheckedInput_companionLinkHealth.Visible = False
                CheckedInput_companionLinkShield.Visible = False
                NumericInput_companionStability.Enabled = False
            Else
                CheckedInput_companionLinkArmor.Visible = True
                CheckedInput_companionLinkHealth.Visible = True
                CheckedInput_companionLinkShield.Visible = True
                NumericInput_companionStability.Enabled = True
            End If

            Dim currentVariant As [Variant] = currentCompanion.Variants.Find(Function(var) var.Name = VariantSelection_companions.SelectedVariant)
            baseArmor = currentVariant.Armor
            baseHealth = currentVariant.Health
            baseShield = currentVariant.Shield

            If currentCompanion.Type = "sentinel" Then
                Armor = baseArmor
                Health = baseHealth
                Shield = baseShield
            Else
                If Not currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "armor") Is Nothing Then
                    Armor = baseArmor * currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "armor").Multiplier
                Else
                    Armor = baseArmor * DefaultRankMultipliers.Companions.Find(Function(m) m.Name = "armor").Multiplier
                End If
                If Not currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "health") Is Nothing Then
                    Health = baseHealth * currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "health").Multiplier
                Else
                    Health = baseHealth * DefaultRankMultipliers.Companions.Find(Function(m) m.Name = "health").Multiplier
                End If
                If Not currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "shield") Is Nothing Then
                    Shield = baseShield * currentCompanion.Rank_Multipliers.Find(Function(rm) rm.Name = "shield").Multiplier
                Else
                    Shield = baseShield * DefaultRankMultipliers.Companions.Find(Function(m) m.Name = "shield").Multiplier
                End If
            End If

            If NumericInput_companionStability.Enabled = True Then
                'genetic stability
                Health *= 1 + (NumericInput_companionStability.Value / 100)
            End If

            damageReduction = StatBox_warframeDamageReduction.Value / 100
            If currentWarframe IsNot Nothing Then
                If currentWarframe.Name = "Oberon" And Not currentCompanion.Type = "sentinel" And Not currentCompanion.Type = "moa" Then
                    If (currentCompanion.Name IsNot "Venari") Then
                        'Oberon Passive
                        armorBonus += StatBox_warframeArmor.Value * 0.25
                        healthBonus += StatBox_warframeHealth.Value * 0.25
                        shieldBonus += StatBox_warframeShield.Value * 0.25
                    End If
                End If
            End If
            If CheckBox_companionPrimeCollar.Enabled And CheckBox_companionPrimeCollar.Checked Then
                armorBonus += 100
                healthBonus += 10
                shieldBonus += 10
            End If
            If CheckedGroupBox_companionSurvivability.Checked Then
                If Not currentCompanion.Type = "sentinel" Then
                    If CheckedInput_companionLinkArmor.Checked = True Then
                        armorBonus += StatBox_warframeArmor.Value * ((CheckedInput_companionLinkArmor.Value + 1) * 0.1)
                    End If
                    If CheckedInput_companionLinkHealth.Checked = True Then
                        healthBonus += StatBox_warframeHealth.Value * ((CheckedInput_companionLinkHealth.Value + 1) * 0.15)
                    End If
                    If CheckedInput_companionLinkShield.Checked = True Then
                        shieldBonus += StatBox_warframeShield.Value * ((CheckedInput_companionLinkShield.Value + 1) * 0.1)
                    End If
                End If
                If CheckedInput_companionMetalFiber.Checked = True Then
                    armorMultiplier += (CheckedInput_companionLinkArmor.Value + 1) * 0.1
                End If
                If CheckedInput_companionEnhancedVitality.Checked = True Then
                    healthMultiplier += (CheckedInput_companionLinkHealth.Value + 1) * 0.2
                End If
                If CheckedInput_companionCalculatedRedirection.Checked = True Then
                    shieldMultiplier += (CheckedInput_companionLinkShield.Value + 1) * 0.25
                End If
            End If

            If CheckedGroupBox_aura.Checked Then
                If RadioInput_shepherd.Checked = True Then
                    armorBonus += 30 + (30 * RadioInput_shepherd.Value)
                    healthBonus += 50 + (50 * RadioInput_shepherd.Value)
                End If
            End If

            Armor = (baseArmor * (1 + armorMultiplier)) + (Armor - baseArmor) + armorBonus
            Health = (baseHealth * (1 + healthMultiplier)) + (Health - baseHealth) + healthBonus
            Shield = (baseShield * (1 + shieldMultiplier)) + (Shield - baseShield) + shieldBonus

            Dim damageReductionArmor = Armor / (300 + Armor)
            Dim totalDamageReduction = damageReductionArmor + ((1 - damageReductionArmor) * damageReduction)
            Dim effectiveHealth = (Health / (1 - totalDamageReduction)) + Shield
            StatBox_companionArmor.Value = Armor
            StatBox_companionHealth.Value = Health
            StatBox_companionShield.Value = Shield
            StatBox_companionDamageReduction.Value = damageReduction
            StatBox_companionEHP.Value = effectiveHealth
            Button_companionExport.Enabled = True
        Else
            Button_companionExport.Enabled = False
            StatBox_companionArmor.Value = Nothing
            StatBox_companionHealth.Value = Nothing
            StatBox_companionShield.Value = Nothing
            StatBox_companionDamageReduction.Value = Nothing
            StatBox_companionEHP.Value = Nothing
        End If
    End Sub

    Private Sub Archwing_Value_Changed(sender As Object, e As EventArgs)
        '
        '   Default Stats
        '
        Dim baseArmor As Decimal = 0.0
        Dim Armor As Decimal = 0.0
        Dim baseHealth As Decimal = 0.0
        Dim Health As Decimal = 0.0
        Dim baseShield As Decimal = 0.0
        Dim Shield As Decimal = 0.0
        Dim baseEnergy As Decimal = 0.0
        Dim Energy As Decimal = 0.0
        Dim basePowerStrength As Decimal = 0.0
        Dim powerStrength As Decimal = 0.0
        '
        '   Default Multipliers (From Mods)
        '   and bonus added armor
        '
        Dim armorMultiplier As Decimal = 0.0
        Dim healthMultiplier As Decimal = 0.0
        Dim shieldMultiplier As Decimal = 0.0
        Dim energyMultiplier As Decimal = 0.0
        Dim armorBonus As Decimal = 0.0
        Dim healthBonus As Decimal = 0.0
        Dim shieldBonus As Decimal = 0.0
        Dim energyBonus As Decimal = 0.0
        Dim damageReduction As Decimal = 0.0
        '
        '   Sepical Hidden stat for abilities that
        '   100% absorb x amount dmg
        '
        Dim damageAbsorbstion As Decimal = 0.0
        If ComboBox_archwings.SelectedIndex > 0 Then
            Dim currentArchwing As Archwing = Archwings.Find(Function(aw) aw.Name = ComboBox_archwings.SelectedItem)
            Dim hasPrime As Boolean = Not currentArchwing.Variants.Find(Function(var) var.Name = "prime") Is Nothing
            If hasPrime Then
                CheckBox_archwingPrime.Enabled = True
            Else
                CheckBox_archwingPrime.Enabled = False
            End If
            '
            ' Stats
            '
            Dim currentVariant As [Variant] = currentArchwing.Variants.Find(Function(var) var.Name = If(CheckBox_archwingPrime.Enabled And CheckBox_archwingPrime.Checked, "prime", "base"))
            baseArmor = currentVariant.Armor
            baseHealth = currentVariant.Health
            baseShield = currentVariant.Shield
            baseEnergy = currentVariant.Energy
            basePowerStrength = currentVariant.strength / 100
            If Not currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "armor") Is Nothing Then
                Armor = baseArmor * currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "armor").Multiplier
            Else
                Armor = baseArmor * DefaultRankMultipliers.Archwings.Find(Function(m) m.Name = "armor").Multiplier
            End If
            If Not currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "health") Is Nothing Then
                Health = baseHealth * currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "health").Multiplier
            Else
                Health = baseHealth * DefaultRankMultipliers.Archwings.Find(Function(m) m.Name = "health").Multiplier
            End If
            If Not currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "shield") Is Nothing Then
                Shield = baseShield * currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "shield").Multiplier
            Else
                Shield = baseShield * DefaultRankMultipliers.Archwings.Find(Function(m) m.Name = "shield").Multiplier
            End If
            If Not currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "energy") Is Nothing Then
                Energy = baseEnergy * currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "energy").Multiplier
            Else
                Energy = baseEnergy * DefaultRankMultipliers.Archwings.Find(Function(m) m.Name = "energy").Multiplier
            End If
            If Not currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "strength") Is Nothing Then
                powerStrength = basePowerStrength * currentArchwing.Rank_Multipliers.Find(Function(rm) rm.Name = "strength").Multiplier
            Else
                powerStrength = basePowerStrength * DefaultRankMultipliers.Archwings.Find(Function(m) m.Name = "strength").Multiplier
            End If
            '
            '   Mods
            '
            If CheckedGroupBox_archwingAura.Checked Then
                If RadioInput_physique.Checked Then
                    Dim physique As Decimal = 0.15 + (RadioInput_archwingPhysique.Value * 0.15)
                    If CheckedInput_archwingCoactionDrift.Checked And CheckedGroupBox_archwingMiscellaneous.Checked Then
                        '
                        '   Coaction Drift is Strange, it gives you a 0.15 boost to all Auras
                        '   and another 0.15 boost to your Aura ontop of the other for a total
                        '   of 0.15 * (1 + 0.15) + 0.15 = 0.3225 (values are for max rank mod)
                        '
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_archwingCoactionDrift.Value)
                        healthMultiplier += physique + (physique * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        healthMultiplier += physique
                    End If
                ElseIf RadioInput_archwingStandUnited.Checked Then
                    Dim standUnited As Decimal = 0.0425 + (RadioInput_archwingStandUnited.Value * 0.0425)
                    If CheckedInput_archwingCoactionDrift.Checked And CheckedGroupBox_archwingMiscellaneous.Checked Then
                        Dim coactionDrit As Decimal = 0.025 + (0.025 * CheckedInput_archwingCoactionDrift.Value)
                        armorMultiplier += standUnited + (standUnited * (coactionDrit * (1 + coactionDrit) + coactionDrit))
                    Else
                        armorMultiplier += standUnited
                    End If
                End If
            End If
            If CheckedGroupBox_archwingSurvivability.Checked Then
                If CheckedInput_argonPlating.Checked Then
                    armorMultiplier += 0.15 + (CheckedInput_argonPlating.Value * 0.15)
                End If
                If CheckedInput_enhancedDurability.Checked Then
                    healthMultiplier += 0.25 + (CheckedInput_enhancedDurability.Value * 0.25)
                End If
                If CheckedInput_energyInversion.Checked Then
                    shieldMultiplier += 0.3 + (CheckedInput_energyInversion.Value * 0.3)
                End If
            End If
            '
            ' Finalize Stats
            '
            Armor = (baseArmor * (1 + armorMultiplier)) + (Armor - baseArmor) + armorBonus
            Health = (baseHealth * (1 + healthMultiplier)) + (Health - baseHealth) + healthBonus
            Shield = (baseShield * (1 + shieldMultiplier)) + (Shield - baseShield) + shieldBonus
            Energy = (baseEnergy * (1 + energyMultiplier)) + (Energy - baseEnergy) + energyBonus
            '
            '   Display Stats
            '
            StatBox_archwingArmor.Value = Armor
            StatBox_archwingHealth.Value = Health
            StatBox_archwingShield.Value = Shield
            StatBox_archwingEnergy.Value = Energy
            StatBox_archwingPowerStrength.Value = powerStrength * 100
            StatBox_archwingDamageReduction.Value = damageReduction * 100
            '
            '   Calculate EHP
            '
            Dim damageReductionArmor As Decimal = Armor / (300 + Armor)
            Dim totalDamageReduction As Decimal = damageReductionArmor + ((1 - damageReductionArmor) * damageReduction)
            Dim effectiveHealth As Integer = Math.Ceiling((Health / (1 - totalDamageReduction)) + (Shield / (1 - damageReduction)) + damageAbsorbstion)
            StatBox_archwingEHP.Value = effectiveHealth
            '
            ' enable export
            '
            Button_archwingExport.Enabled = True
        Else
            '
            '   No Archwing selected, display values should be set to default
            '
            Button_archwingExport.Enabled = False
            StatBox_archwingArmor.Value = Nothing
            StatBox_archwingHealth.Value = Nothing
            StatBox_archwingShield.Value = Nothing
            StatBox_archwingEnergy.Value = Nothing
            StatBox_archwingPowerStrength.Value = Nothing
            StatBox_archwingEHP.Value = Nothing
            StatBox_archwingDamageReduction.Value = Nothing
        End If
    End Sub

End Class
