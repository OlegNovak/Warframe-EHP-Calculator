﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl_main = New System.Windows.Forms.TabControl()
        Me.TabPage_warframe = New System.Windows.Forms.TabPage()
        Me.GroupBox_warframeResults = New System.Windows.Forms.GroupBox()
        Me.Label_warframePowerStrength = New System.Windows.Forms.Label()
        Me.TextBox_warframePowerStrength = New System.Windows.Forms.TextBox()
        Me.Label_warframeEHP = New System.Windows.Forms.Label()
        Me.TextBox_warframeEHP = New System.Windows.Forms.TextBox()
        Me.Label_warframeEnergy = New System.Windows.Forms.Label()
        Me.TextBox_warframeEnergy = New System.Windows.Forms.TextBox()
        Me.Label_warframeShield = New System.Windows.Forms.Label()
        Me.TextBox_warframeShield = New System.Windows.Forms.TextBox()
        Me.Label_warframeHealth = New System.Windows.Forms.Label()
        Me.TextBox_warframeHealth = New System.Windows.Forms.TextBox()
        Me.Label_warframeArmor = New System.Windows.Forms.Label()
        Me.TextBox_warframeArmor = New System.Windows.Forms.TextBox()
        Me.CheckBox_arcaneHelmets = New System.Windows.Forms.CheckBox()
        Me.CustomTabControl_arcaneHelmets = New Warframe_EHP_Calculator_v2.CustomTabControl()
        Me.TabPage_arcaneHelmetsDefault = New System.Windows.Forms.TabPage()
        Me.Label_arcaneHelmetPlaceholder = New System.Windows.Forms.Label()
        Me.TabPage_arcaneHelmetsAsh = New System.Windows.Forms.TabPage()
        Me.RadioButton_locustHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsBanshee = New System.Windows.Forms.TabPage()
        Me.RadioButton_reverbHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsEmber = New System.Windows.Forms.TabPage()
        Me.RadioButton_backdraftHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_phoenixHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsExcalibur = New System.Windows.Forms.TabPage()
        Me.RadioButton_pendragonHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_avalonHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsFrost = New System.Windows.Forms.TabPage()
        Me.RadioButton_squallHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_auroraHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsLoki = New System.Windows.Forms.TabPage()
        Me.RadioButton_swindleHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_essenceHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsMag = New System.Windows.Forms.TabPage()
        Me.RadioButton_gaussHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_coilHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsNova = New System.Windows.Forms.TabPage()
        Me.RadioButton_fluxHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsNyx = New System.Windows.Forms.TabPage()
        Me.RadioButton_vespaHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_menticideHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsRhino = New System.Windows.Forms.TabPage()
        Me.RadioButton_vanguardHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_thrak = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsSaryn = New System.Windows.Forms.TabPage()
        Me.RadioButton_hemlockHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsTrinity = New System.Windows.Forms.TabPage()
        Me.RadioButton_meridianHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_auraHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsVauban = New System.Windows.Forms.TabPage()
        Me.RadioButton_espritHelmet = New System.Windows.Forms.RadioButton()
        Me.TabPage_arcaneHelmetsVolt = New System.Windows.Forms.TabPage()
        Me.RadioButton_stormHelmet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_pulseHelmet = New System.Windows.Forms.RadioButton()
        Me.CheckBox_oversheilds = New System.Windows.Forms.CheckBox()
        Me.GroupBox_oversheilds = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_oversheilds = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_focus = New System.Windows.Forms.CheckBox()
        Me.CheckBox_abilities = New System.Windows.Forms.CheckBox()
        Me.CheckBox_dragonKeys = New System.Windows.Forms.CheckBox()
        Me.CheckBox_arcanes = New System.Windows.Forms.CheckBox()
        Me.GroupBox_dragonKeys = New System.Windows.Forms.GroupBox()
        Me.RadioButton_decayingKey = New System.Windows.Forms.RadioButton()
        Me.RadioButton_bleedingKey = New System.Windows.Forms.RadioButton()
        Me.GroupBox_arcanes = New System.Windows.Forms.GroupBox()
        Me.CheckBox_arcaneGuardian = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_arcaneUltimatum = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_arcaneGuardian = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_arcaneUltimatum = New System.Windows.Forms.CheckBox()
        Me.CheckBox_miscellaneous = New System.Windows.Forms.CheckBox()
        Me.GroupBox_miscellaneous = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_enduranceDrift = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_flow = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_flow = New System.Windows.Forms.CheckBox()
        Me.CheckBox_enduranceDrift = New System.Windows.Forms.CheckBox()
        Me.CheckBox_coactionDrift = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_coactionDrift = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_power = New System.Windows.Forms.CheckBox()
        Me.GroupBox_power = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_overextended = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_overextended = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_transientFortitude = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_transientFortitude = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_intensify = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_intensify = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_powerDrift = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_powerDrift = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_blindRage = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_blindRage = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_energyConversion = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_energyConversion = New System.Windows.Forms.CheckBox()
        Me.CheckBox_survivability = New System.Windows.Forms.CheckBox()
        Me.GroupBox_survivability = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_armoredAgility = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_steelFiber = New System.Windows.Forms.CheckBox()
        Me.CheckBox_armoredAgility = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_vigor = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_healthConversionStacks = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_quickThinking = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_redirection = New System.Windows.Forms.NumericUpDown()
        Me.Label_healthConversionStacks = New System.Windows.Forms.Label()
        Me.CheckBox_quickThinking = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_vitality = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_healthConversion = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_vigor = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_steelFiber = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_healthConversion = New System.Windows.Forms.CheckBox()
        Me.CheckBox_redirection = New System.Windows.Forms.CheckBox()
        Me.CheckBox_vitality = New System.Windows.Forms.CheckBox()
        Me.CheckBox_aura = New System.Windows.Forms.CheckBox()
        Me.GroupBox_aura = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_growingPower = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_growingPower = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown_standUnited = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_standUnited = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown_physique = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_physique = New System.Windows.Forms.RadioButton()
        Me.CheckBox_isUmbra = New System.Windows.Forms.CheckBox()
        Me.ComboBox_warframes = New System.Windows.Forms.ComboBox()
        Me.CheckBox_isPrime = New System.Windows.Forms.CheckBox()
        Me.CustomTabControl_abilitys = New Warframe_EHP_Calculator_v2.CustomTabControl()
        Me.TabPage_abilitiesDefault = New System.Windows.Forms.TabPage()
        Me.Label_abilityPlaceholder = New System.Windows.Forms.Label()
        Me.TabPage_abilitiesChroma = New System.Windows.Forms.TabPage()
        Me.CheckBox_vexArmor = New System.Windows.Forms.CheckBox()
        Me.CheckBox_elementalWard = New System.Windows.Forms.CheckBox()
        Me.RadioButton_electricChroma = New System.Windows.Forms.RadioButton()
        Me.RadioButton_iceChroma = New System.Windows.Forms.RadioButton()
        Me.RadioButton_fireChroma = New System.Windows.Forms.RadioButton()
        Me.TabPage_abilitiesFrost = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_icyAvalanche = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_icyAvalanche = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesInaros = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_scarabSwarm = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_scarabSwarm = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesMesa = New System.Windows.Forms.TabPage()
        Me.CheckBox_shatterShield = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesMirage = New System.Windows.Forms.TabPage()
        Me.CheckBox_eclipse = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesNekros = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_shieldOfShadows = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_shieldOfShadows = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesNezha = New System.Windows.Forms.TabPage()
        Me.Label_wardingHalo = New System.Windows.Forms.Label()
        Me.NumericUpDown_wardingHalo = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_wardingHalo = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesNidus = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_mutationStacks = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_mutationStacks = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesOberon = New System.Windows.Forms.TabPage()
        Me.CheckBox_hallowedReckoning = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ironRenewal = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesRhino = New System.Windows.Forms.TabPage()
        Me.NumericUpDown_ironcladCharge = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_ironcladCharge = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ironSkin = New System.Windows.Forms.CheckBox()
        Me.Label_ironSkin = New System.Windows.Forms.Label()
        Me.NumericUpDown_ironSkin = New System.Windows.Forms.NumericUpDown()
        Me.TabPage_abilitiesTrinity = New System.Windows.Forms.TabPage()
        Me.CheckBox_blessing = New System.Windows.Forms.CheckBox()
        Me.CheckBox_link = New System.Windows.Forms.CheckBox()
        Me.TabPage_abilitiesValkyr = New System.Windows.Forms.TabPage()
        Me.CheckBox_warcry = New System.Windows.Forms.CheckBox()
        Me.Panel_Ruler = New System.Windows.Forms.Panel()
        Me.GroupBox_focus = New System.Windows.Forms.GroupBox()
        Me.Label_focusPlaceholder = New System.Windows.Forms.Label()
        Me.Panel_RulerTwo = New System.Windows.Forms.Panel()
        Me.TabPage_companion = New System.Windows.Forms.TabPage()
        Me.GroupBox_companionResults = New System.Windows.Forms.GroupBox()
        Me.Label_companionEHP = New System.Windows.Forms.Label()
        Me.TextBox_companionEHP = New System.Windows.Forms.TextBox()
        Me.TextBox_companionArmor = New System.Windows.Forms.TextBox()
        Me.Label_companionShield = New System.Windows.Forms.Label()
        Me.TextBox_companionShield = New System.Windows.Forms.TextBox()
        Me.Label_companionHealth = New System.Windows.Forms.Label()
        Me.TextBox_companionHealth = New System.Windows.Forms.TextBox()
        Me.Label_companionArmor = New System.Windows.Forms.Label()
        Me.NumericUpDown_companionStability = New System.Windows.Forms.NumericUpDown()
        Me.Label_companionStability = New System.Windows.Forms.Label()
        Me.CheckBox_companionSurvivability = New System.Windows.Forms.CheckBox()
        Me.GroupBox_companionSurvivability = New System.Windows.Forms.GroupBox()
        Me.CheckBox_companionLinkShield = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_companionLinkShield = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_companionLinkHealth = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_companionLinkHealth = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_companionLinkArmor = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_companionLinkArmor = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_companionPrimeCollar = New System.Windows.Forms.CheckBox()
        Me.ComboBox_companions = New System.Windows.Forms.ComboBox()
        Me.TabPage_development = New System.Windows.Forms.TabPage()
        Me.ComboBox_umbraPower = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraBasePower = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primePower = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeBasePower = New System.Windows.Forms.ComboBox()
        Me.ComboBox_power = New System.Windows.Forms.ComboBox()
        Me.ComboBox_basePower = New System.Windows.Forms.ComboBox()
        Me.Label_devUmbraStats = New System.Windows.Forms.Label()
        Me.ComboBox_umbraEnergy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraArmor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraBaseEnergy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraBaseShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraBaseHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbraBaseArmor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_umbras = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_companions = New System.Windows.Forms.Label()
        Me.Label_devPrimeStats = New System.Windows.Forms.Label()
        Me.Label_devStats = New System.Windows.Forms.Label()
        Me.ComboBox_primeEnergy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeArmor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeBaseEnergy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeBaseShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeBaseHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primeBaseArmor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_primes = New System.Windows.Forms.ComboBox()
        Me.ComboBox_petShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_petHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_petArmor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_energy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_shield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_health = New System.Windows.Forms.ComboBox()
        Me.ComboBox_armor = New System.Windows.Forms.ComboBox()
        Me.ComboBox_baseEnergy = New System.Windows.Forms.ComboBox()
        Me.ComboBox_baseShield = New System.Windows.Forms.ComboBox()
        Me.ComboBox_baseHealth = New System.Windows.Forms.ComboBox()
        Me.ComboBox_baseArmor = New System.Windows.Forms.ComboBox()
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_author = New System.Windows.Forms.Label()
        Me.Label_love = New System.Windows.Forms.Label()
        Me.TabControl_main.SuspendLayout()
        Me.TabPage_warframe.SuspendLayout()
        Me.GroupBox_warframeResults.SuspendLayout()
        Me.CustomTabControl_arcaneHelmets.SuspendLayout()
        Me.TabPage_arcaneHelmetsDefault.SuspendLayout()
        Me.TabPage_arcaneHelmetsAsh.SuspendLayout()
        Me.TabPage_arcaneHelmetsBanshee.SuspendLayout()
        Me.TabPage_arcaneHelmetsEmber.SuspendLayout()
        Me.TabPage_arcaneHelmetsExcalibur.SuspendLayout()
        Me.TabPage_arcaneHelmetsFrost.SuspendLayout()
        Me.TabPage_arcaneHelmetsLoki.SuspendLayout()
        Me.TabPage_arcaneHelmetsMag.SuspendLayout()
        Me.TabPage_arcaneHelmetsNova.SuspendLayout()
        Me.TabPage_arcaneHelmetsNyx.SuspendLayout()
        Me.TabPage_arcaneHelmetsRhino.SuspendLayout()
        Me.TabPage_arcaneHelmetsSaryn.SuspendLayout()
        Me.TabPage_arcaneHelmetsTrinity.SuspendLayout()
        Me.TabPage_arcaneHelmetsVauban.SuspendLayout()
        Me.TabPage_arcaneHelmetsVolt.SuspendLayout()
        Me.GroupBox_oversheilds.SuspendLayout()
        CType(Me.NumericUpDown_oversheilds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_dragonKeys.SuspendLayout()
        Me.GroupBox_arcanes.SuspendLayout()
        CType(Me.NumericUpDown_arcaneUltimatum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_arcaneGuardian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_miscellaneous.SuspendLayout()
        CType(Me.NumericUpDown_enduranceDrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_flow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_coactionDrift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_power.SuspendLayout()
        CType(Me.NumericUpDown_overextended, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_transientFortitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_intensify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_powerDrift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_blindRage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_energyConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_survivability.SuspendLayout()
        CType(Me.NumericUpDown_armoredAgility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_vigor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_healthConversionStacks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_quickThinking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_redirection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_vitality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_healthConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_steelFiber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_aura.SuspendLayout()
        CType(Me.NumericUpDown_growingPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_standUnited, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_physique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomTabControl_abilitys.SuspendLayout()
        Me.TabPage_abilitiesDefault.SuspendLayout()
        Me.TabPage_abilitiesChroma.SuspendLayout()
        Me.TabPage_abilitiesFrost.SuspendLayout()
        CType(Me.NumericUpDown_icyAvalanche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesInaros.SuspendLayout()
        CType(Me.NumericUpDown_scarabSwarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesMesa.SuspendLayout()
        Me.TabPage_abilitiesMirage.SuspendLayout()
        Me.TabPage_abilitiesNekros.SuspendLayout()
        CType(Me.NumericUpDown_shieldOfShadows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesNezha.SuspendLayout()
        CType(Me.NumericUpDown_wardingHalo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesNidus.SuspendLayout()
        CType(Me.NumericUpDown_mutationStacks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesOberon.SuspendLayout()
        Me.TabPage_abilitiesRhino.SuspendLayout()
        CType(Me.NumericUpDown_ironcladCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_ironSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_abilitiesTrinity.SuspendLayout()
        Me.TabPage_abilitiesValkyr.SuspendLayout()
        Me.GroupBox_focus.SuspendLayout()
        Me.TabPage_companion.SuspendLayout()
        Me.GroupBox_companionResults.SuspendLayout()
        CType(Me.NumericUpDown_companionStability, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_companionSurvivability.SuspendLayout()
        CType(Me.NumericUpDown_companionLinkShield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_companionLinkHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_companionLinkArmor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_development.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_main
        '
        Me.TabControl_main.Controls.Add(Me.TabPage_warframe)
        Me.TabControl_main.Controls.Add(Me.TabPage_companion)
        Me.TabControl_main.Controls.Add(Me.TabPage_development)
        Me.TabControl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl_main.ImageList = Me.Icons
        Me.TabControl_main.ItemSize = New System.Drawing.Size(115, 25)
        Me.TabControl_main.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_main.Name = "TabControl_main"
        Me.TabControl_main.SelectedIndex = 0
        Me.TabControl_main.Size = New System.Drawing.Size(1026, 520)
        Me.TabControl_main.TabIndex = 0
        '
        'TabPage_warframe
        '
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_warframeResults)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_arcaneHelmets)
        Me.TabPage_warframe.Controls.Add(Me.CustomTabControl_arcaneHelmets)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_oversheilds)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_oversheilds)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_focus)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_abilities)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_dragonKeys)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_arcanes)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_dragonKeys)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_arcanes)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_miscellaneous)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_miscellaneous)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_power)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_power)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_survivability)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_survivability)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_aura)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_aura)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_isUmbra)
        Me.TabPage_warframe.Controls.Add(Me.ComboBox_warframes)
        Me.TabPage_warframe.Controls.Add(Me.CheckBox_isPrime)
        Me.TabPage_warframe.Controls.Add(Me.CustomTabControl_abilitys)
        Me.TabPage_warframe.Controls.Add(Me.Panel_Ruler)
        Me.TabPage_warframe.Controls.Add(Me.GroupBox_focus)
        Me.TabPage_warframe.Controls.Add(Me.Panel_RulerTwo)
        Me.TabPage_warframe.ImageKey = "warframe.png"
        Me.TabPage_warframe.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_warframe.Name = "TabPage_warframe"
        Me.TabPage_warframe.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_warframe.Size = New System.Drawing.Size(1018, 487)
        Me.TabPage_warframe.TabIndex = 0
        Me.TabPage_warframe.Text = "Warframe "
        Me.TabPage_warframe.UseVisualStyleBackColor = True
        '
        'GroupBox_warframeResults
        '
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframePowerStrength)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframePowerStrength)
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframeEHP)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframeEHP)
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframeEnergy)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframeEnergy)
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframeShield)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframeShield)
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframeHealth)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframeHealth)
        Me.GroupBox_warframeResults.Controls.Add(Me.Label_warframeArmor)
        Me.GroupBox_warframeResults.Controls.Add(Me.TextBox_warframeArmor)
        Me.GroupBox_warframeResults.Location = New System.Drawing.Point(773, 36)
        Me.GroupBox_warframeResults.Name = "GroupBox_warframeResults"
        Me.GroupBox_warframeResults.Size = New System.Drawing.Size(237, 445)
        Me.GroupBox_warframeResults.TabIndex = 118
        Me.GroupBox_warframeResults.TabStop = False
        '
        'Label_warframePowerStrength
        '
        Me.Label_warframePowerStrength.AutoSize = True
        Me.Label_warframePowerStrength.Location = New System.Drawing.Point(11, 129)
        Me.Label_warframePowerStrength.Name = "Label_warframePowerStrength"
        Me.Label_warframePowerStrength.Size = New System.Drawing.Size(109, 17)
        Me.Label_warframePowerStrength.TabIndex = 11
        Me.Label_warframePowerStrength.Text = "Power Strength:"
        '
        'TextBox_warframePowerStrength
        '
        Me.TextBox_warframePowerStrength.Location = New System.Drawing.Point(124, 126)
        Me.TextBox_warframePowerStrength.Name = "TextBox_warframePowerStrength"
        Me.TextBox_warframePowerStrength.ReadOnly = True
        Me.TextBox_warframePowerStrength.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframePowerStrength.TabIndex = 10
        Me.TextBox_warframePowerStrength.Text = "-"
        Me.TextBox_warframePowerStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_warframeEHP
        '
        Me.Label_warframeEHP.AutoSize = True
        Me.Label_warframeEHP.Location = New System.Drawing.Point(11, 412)
        Me.Label_warframeEHP.Name = "Label_warframeEHP"
        Me.Label_warframeEHP.Size = New System.Drawing.Size(111, 17)
        Me.Label_warframeEHP.TabIndex = 9
        Me.Label_warframeEHP.Text = "Effective Health:"
        '
        'TextBox_warframeEHP
        '
        Me.TextBox_warframeEHP.Location = New System.Drawing.Point(124, 409)
        Me.TextBox_warframeEHP.Name = "TextBox_warframeEHP"
        Me.TextBox_warframeEHP.ReadOnly = True
        Me.TextBox_warframeEHP.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframeEHP.TabIndex = 8
        Me.TextBox_warframeEHP.Text = "-"
        Me.TextBox_warframeEHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_warframeEnergy
        '
        Me.Label_warframeEnergy.AutoSize = True
        Me.Label_warframeEnergy.Location = New System.Drawing.Point(11, 103)
        Me.Label_warframeEnergy.Name = "Label_warframeEnergy"
        Me.Label_warframeEnergy.Size = New System.Drawing.Size(57, 17)
        Me.Label_warframeEnergy.TabIndex = 7
        Me.Label_warframeEnergy.Text = "Energy:"
        '
        'TextBox_warframeEnergy
        '
        Me.TextBox_warframeEnergy.Location = New System.Drawing.Point(124, 100)
        Me.TextBox_warframeEnergy.Name = "TextBox_warframeEnergy"
        Me.TextBox_warframeEnergy.ReadOnly = True
        Me.TextBox_warframeEnergy.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframeEnergy.TabIndex = 6
        Me.TextBox_warframeEnergy.Text = "-"
        Me.TextBox_warframeEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_warframeShield
        '
        Me.Label_warframeShield.AutoSize = True
        Me.Label_warframeShield.Location = New System.Drawing.Point(11, 77)
        Me.Label_warframeShield.Name = "Label_warframeShield"
        Me.Label_warframeShield.Size = New System.Drawing.Size(51, 17)
        Me.Label_warframeShield.TabIndex = 5
        Me.Label_warframeShield.Text = "Shield:"
        '
        'TextBox_warframeShield
        '
        Me.TextBox_warframeShield.Location = New System.Drawing.Point(124, 74)
        Me.TextBox_warframeShield.Name = "TextBox_warframeShield"
        Me.TextBox_warframeShield.ReadOnly = True
        Me.TextBox_warframeShield.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframeShield.TabIndex = 4
        Me.TextBox_warframeShield.Text = "-"
        Me.TextBox_warframeShield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_warframeHealth
        '
        Me.Label_warframeHealth.AutoSize = True
        Me.Label_warframeHealth.Location = New System.Drawing.Point(11, 51)
        Me.Label_warframeHealth.Name = "Label_warframeHealth"
        Me.Label_warframeHealth.Size = New System.Drawing.Size(53, 17)
        Me.Label_warframeHealth.TabIndex = 3
        Me.Label_warframeHealth.Text = "Health:"
        '
        'TextBox_warframeHealth
        '
        Me.TextBox_warframeHealth.Location = New System.Drawing.Point(124, 48)
        Me.TextBox_warframeHealth.Name = "TextBox_warframeHealth"
        Me.TextBox_warframeHealth.ReadOnly = True
        Me.TextBox_warframeHealth.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframeHealth.TabIndex = 2
        Me.TextBox_warframeHealth.Text = "-"
        Me.TextBox_warframeHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_warframeArmor
        '
        Me.Label_warframeArmor.AutoSize = True
        Me.Label_warframeArmor.Location = New System.Drawing.Point(11, 25)
        Me.Label_warframeArmor.Name = "Label_warframeArmor"
        Me.Label_warframeArmor.Size = New System.Drawing.Size(50, 17)
        Me.Label_warframeArmor.TabIndex = 1
        Me.Label_warframeArmor.Text = "Armor:"
        '
        'TextBox_warframeArmor
        '
        Me.TextBox_warframeArmor.Location = New System.Drawing.Point(124, 22)
        Me.TextBox_warframeArmor.Name = "TextBox_warframeArmor"
        Me.TextBox_warframeArmor.ReadOnly = True
        Me.TextBox_warframeArmor.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_warframeArmor.TabIndex = 0
        Me.TextBox_warframeArmor.Text = "-"
        Me.TextBox_warframeArmor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox_arcaneHelmets
        '
        Me.CheckBox_arcaneHelmets.AutoSize = True
        Me.CheckBox_arcaneHelmets.Enabled = False
        Me.CheckBox_arcaneHelmets.Location = New System.Drawing.Point(498, 397)
        Me.CheckBox_arcaneHelmets.Name = "CheckBox_arcaneHelmets"
        Me.CheckBox_arcaneHelmets.Size = New System.Drawing.Size(127, 21)
        Me.CheckBox_arcaneHelmets.TabIndex = 110
        Me.CheckBox_arcaneHelmets.Tag = "CustomTabControl_arcaneHelmets"
        Me.CheckBox_arcaneHelmets.Text = "Arcane Helmets"
        Me.CheckBox_arcaneHelmets.UseVisualStyleBackColor = True
        '
        'CustomTabControl_arcaneHelmets
        '
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsDefault)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsAsh)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsBanshee)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsEmber)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsExcalibur)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsFrost)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsLoki)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsMag)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsNova)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsNyx)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsRhino)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsSaryn)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsTrinity)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsVauban)
        Me.CustomTabControl_arcaneHelmets.Controls.Add(Me.TabPage_arcaneHelmetsVolt)
        Me.CustomTabControl_arcaneHelmets.Enabled = False
        Me.CustomTabControl_arcaneHelmets.Location = New System.Drawing.Point(487, 405)
        Me.CustomTabControl_arcaneHelmets.Name = "CustomTabControl_arcaneHelmets"
        Me.CustomTabControl_arcaneHelmets.SelectedIndex = 0
        Me.CustomTabControl_arcaneHelmets.Size = New System.Drawing.Size(281, 75)
        Me.CustomTabControl_arcaneHelmets.TabIndex = 117
        '
        'TabPage_arcaneHelmetsDefault
        '
        Me.TabPage_arcaneHelmetsDefault.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsDefault.Controls.Add(Me.Label_arcaneHelmetPlaceholder)
        Me.TabPage_arcaneHelmetsDefault.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsDefault.Name = "TabPage_arcaneHelmetsDefault"
        Me.TabPage_arcaneHelmetsDefault.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsDefault.TabIndex = 2
        Me.TabPage_arcaneHelmetsDefault.Text = "Default"
        '
        'Label_arcaneHelmetPlaceholder
        '
        Me.Label_arcaneHelmetPlaceholder.AutoSize = True
        Me.Label_arcaneHelmetPlaceholder.Location = New System.Drawing.Point(63, 18)
        Me.Label_arcaneHelmetPlaceholder.Name = "Label_arcaneHelmetPlaceholder"
        Me.Label_arcaneHelmetPlaceholder.Size = New System.Drawing.Size(152, 34)
        Me.Label_arcaneHelmetPlaceholder.TabIndex = 1
        Me.Label_arcaneHelmetPlaceholder.Text = "This Warframe has no " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arcane Helmets"
        Me.Label_arcaneHelmetPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage_arcaneHelmetsAsh
        '
        Me.TabPage_arcaneHelmetsAsh.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsAsh.Controls.Add(Me.RadioButton_locustHelmet)
        Me.TabPage_arcaneHelmetsAsh.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsAsh.Name = "TabPage_arcaneHelmetsAsh"
        Me.TabPage_arcaneHelmetsAsh.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_arcaneHelmetsAsh.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsAsh.TabIndex = 0
        Me.TabPage_arcaneHelmetsAsh.Text = "Ash"
        '
        'RadioButton_locustHelmet
        '
        Me.RadioButton_locustHelmet.AutoSize = True
        Me.RadioButton_locustHelmet.Checked = True
        Me.RadioButton_locustHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_locustHelmet.Name = "RadioButton_locustHelmet"
        Me.RadioButton_locustHelmet.Size = New System.Drawing.Size(116, 21)
        Me.RadioButton_locustHelmet.TabIndex = 0
        Me.RadioButton_locustHelmet.TabStop = True
        Me.RadioButton_locustHelmet.Text = "Locust Helmet"
        Me.RadioButton_locustHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsBanshee
        '
        Me.TabPage_arcaneHelmetsBanshee.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsBanshee.Controls.Add(Me.RadioButton_reverbHelmet)
        Me.TabPage_arcaneHelmetsBanshee.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsBanshee.Name = "TabPage_arcaneHelmetsBanshee"
        Me.TabPage_arcaneHelmetsBanshee.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_arcaneHelmetsBanshee.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsBanshee.TabIndex = 1
        Me.TabPage_arcaneHelmetsBanshee.Text = "Banshee"
        '
        'RadioButton_reverbHelmet
        '
        Me.RadioButton_reverbHelmet.AutoSize = True
        Me.RadioButton_reverbHelmet.Checked = True
        Me.RadioButton_reverbHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_reverbHelmet.Name = "RadioButton_reverbHelmet"
        Me.RadioButton_reverbHelmet.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton_reverbHelmet.TabIndex = 1
        Me.RadioButton_reverbHelmet.TabStop = True
        Me.RadioButton_reverbHelmet.Text = "Reverb Helmet"
        Me.RadioButton_reverbHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsEmber
        '
        Me.TabPage_arcaneHelmetsEmber.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsEmber.Controls.Add(Me.RadioButton_backdraftHelmet)
        Me.TabPage_arcaneHelmetsEmber.Controls.Add(Me.RadioButton_phoenixHelmet)
        Me.TabPage_arcaneHelmetsEmber.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsEmber.Name = "TabPage_arcaneHelmetsEmber"
        Me.TabPage_arcaneHelmetsEmber.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsEmber.TabIndex = 3
        Me.TabPage_arcaneHelmetsEmber.Text = "Ember"
        '
        'RadioButton_backdraftHelmet
        '
        Me.RadioButton_backdraftHelmet.AutoSize = True
        Me.RadioButton_backdraftHelmet.Location = New System.Drawing.Point(140, 25)
        Me.RadioButton_backdraftHelmet.Name = "RadioButton_backdraftHelmet"
        Me.RadioButton_backdraftHelmet.Size = New System.Drawing.Size(134, 21)
        Me.RadioButton_backdraftHelmet.TabIndex = 3
        Me.RadioButton_backdraftHelmet.Tag = ""
        Me.RadioButton_backdraftHelmet.Text = "Backdraft Helmet"
        Me.RadioButton_backdraftHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_phoenixHelmet
        '
        Me.RadioButton_phoenixHelmet.AutoSize = True
        Me.RadioButton_phoenixHelmet.Checked = True
        Me.RadioButton_phoenixHelmet.Location = New System.Drawing.Point(10, 25)
        Me.RadioButton_phoenixHelmet.Name = "RadioButton_phoenixHelmet"
        Me.RadioButton_phoenixHelmet.Size = New System.Drawing.Size(124, 21)
        Me.RadioButton_phoenixHelmet.TabIndex = 2
        Me.RadioButton_phoenixHelmet.TabStop = True
        Me.RadioButton_phoenixHelmet.Tag = ""
        Me.RadioButton_phoenixHelmet.Text = "Phoenix Helmet"
        Me.RadioButton_phoenixHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsExcalibur
        '
        Me.TabPage_arcaneHelmetsExcalibur.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsExcalibur.Controls.Add(Me.RadioButton_pendragonHelmet)
        Me.TabPage_arcaneHelmetsExcalibur.Controls.Add(Me.RadioButton_avalonHelmet)
        Me.TabPage_arcaneHelmetsExcalibur.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsExcalibur.Name = "TabPage_arcaneHelmetsExcalibur"
        Me.TabPage_arcaneHelmetsExcalibur.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsExcalibur.TabIndex = 4
        Me.TabPage_arcaneHelmetsExcalibur.Text = "Excalibur"
        '
        'RadioButton_pendragonHelmet
        '
        Me.RadioButton_pendragonHelmet.AutoSize = True
        Me.RadioButton_pendragonHelmet.Location = New System.Drawing.Point(130, 25)
        Me.RadioButton_pendragonHelmet.Name = "RadioButton_pendragonHelmet"
        Me.RadioButton_pendragonHelmet.Size = New System.Drawing.Size(144, 21)
        Me.RadioButton_pendragonHelmet.TabIndex = 4
        Me.RadioButton_pendragonHelmet.Tag = ""
        Me.RadioButton_pendragonHelmet.Text = "Pendragon Helmet"
        Me.RadioButton_pendragonHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_avalonHelmet
        '
        Me.RadioButton_avalonHelmet.AutoSize = True
        Me.RadioButton_avalonHelmet.Checked = True
        Me.RadioButton_avalonHelmet.Location = New System.Drawing.Point(10, 25)
        Me.RadioButton_avalonHelmet.Name = "RadioButton_avalonHelmet"
        Me.RadioButton_avalonHelmet.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton_avalonHelmet.TabIndex = 3
        Me.RadioButton_avalonHelmet.TabStop = True
        Me.RadioButton_avalonHelmet.Tag = ""
        Me.RadioButton_avalonHelmet.Text = "Avalon Helmet"
        Me.RadioButton_avalonHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsFrost
        '
        Me.TabPage_arcaneHelmetsFrost.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsFrost.Controls.Add(Me.RadioButton_squallHelmet)
        Me.TabPage_arcaneHelmetsFrost.Controls.Add(Me.RadioButton_auroraHelmet)
        Me.TabPage_arcaneHelmetsFrost.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsFrost.Name = "TabPage_arcaneHelmetsFrost"
        Me.TabPage_arcaneHelmetsFrost.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsFrost.TabIndex = 5
        Me.TabPage_arcaneHelmetsFrost.Text = "Frost"
        '
        'RadioButton_squallHelmet
        '
        Me.RadioButton_squallHelmet.AutoSize = True
        Me.RadioButton_squallHelmet.Location = New System.Drawing.Point(132, 25)
        Me.RadioButton_squallHelmet.Name = "RadioButton_squallHelmet"
        Me.RadioButton_squallHelmet.Size = New System.Drawing.Size(113, 21)
        Me.RadioButton_squallHelmet.TabIndex = 5
        Me.RadioButton_squallHelmet.Tag = ""
        Me.RadioButton_squallHelmet.Text = "Squall Helmet"
        Me.RadioButton_squallHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_auroraHelmet
        '
        Me.RadioButton_auroraHelmet.AutoSize = True
        Me.RadioButton_auroraHelmet.Checked = True
        Me.RadioButton_auroraHelmet.Location = New System.Drawing.Point(9, 25)
        Me.RadioButton_auroraHelmet.Name = "RadioButton_auroraHelmet"
        Me.RadioButton_auroraHelmet.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton_auroraHelmet.TabIndex = 4
        Me.RadioButton_auroraHelmet.TabStop = True
        Me.RadioButton_auroraHelmet.Tag = ""
        Me.RadioButton_auroraHelmet.Text = "Aurora Helmet"
        Me.RadioButton_auroraHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsLoki
        '
        Me.TabPage_arcaneHelmetsLoki.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsLoki.Controls.Add(Me.RadioButton_swindleHelmet)
        Me.TabPage_arcaneHelmetsLoki.Controls.Add(Me.RadioButton_essenceHelmet)
        Me.TabPage_arcaneHelmetsLoki.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsLoki.Name = "TabPage_arcaneHelmetsLoki"
        Me.TabPage_arcaneHelmetsLoki.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsLoki.TabIndex = 6
        Me.TabPage_arcaneHelmetsLoki.Text = "Loki"
        '
        'RadioButton_swindleHelmet
        '
        Me.RadioButton_swindleHelmet.AutoSize = True
        Me.RadioButton_swindleHelmet.Location = New System.Drawing.Point(145, 25)
        Me.RadioButton_swindleHelmet.Name = "RadioButton_swindleHelmet"
        Me.RadioButton_swindleHelmet.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton_swindleHelmet.TabIndex = 5
        Me.RadioButton_swindleHelmet.Tag = ""
        Me.RadioButton_swindleHelmet.Text = "Swindle Helmet"
        Me.RadioButton_swindleHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_essenceHelmet
        '
        Me.RadioButton_essenceHelmet.AutoSize = True
        Me.RadioButton_essenceHelmet.Checked = True
        Me.RadioButton_essenceHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_essenceHelmet.Name = "RadioButton_essenceHelmet"
        Me.RadioButton_essenceHelmet.Size = New System.Drawing.Size(128, 21)
        Me.RadioButton_essenceHelmet.TabIndex = 4
        Me.RadioButton_essenceHelmet.TabStop = True
        Me.RadioButton_essenceHelmet.Tag = ""
        Me.RadioButton_essenceHelmet.Text = "Essence Helmet"
        Me.RadioButton_essenceHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsMag
        '
        Me.TabPage_arcaneHelmetsMag.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsMag.Controls.Add(Me.RadioButton_gaussHelmet)
        Me.TabPage_arcaneHelmetsMag.Controls.Add(Me.RadioButton_coilHelmet)
        Me.TabPage_arcaneHelmetsMag.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsMag.Name = "TabPage_arcaneHelmetsMag"
        Me.TabPage_arcaneHelmetsMag.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsMag.TabIndex = 7
        Me.TabPage_arcaneHelmetsMag.Text = "Mag"
        '
        'RadioButton_gaussHelmet
        '
        Me.RadioButton_gaussHelmet.AutoSize = True
        Me.RadioButton_gaussHelmet.Location = New System.Drawing.Point(114, 25)
        Me.RadioButton_gaussHelmet.Name = "RadioButton_gaussHelmet"
        Me.RadioButton_gaussHelmet.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton_gaussHelmet.TabIndex = 5
        Me.RadioButton_gaussHelmet.Tag = ""
        Me.RadioButton_gaussHelmet.Text = "Gauss Helmet"
        Me.RadioButton_gaussHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_coilHelmet
        '
        Me.RadioButton_coilHelmet.AutoSize = True
        Me.RadioButton_coilHelmet.Checked = True
        Me.RadioButton_coilHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_coilHelmet.Name = "RadioButton_coilHelmet"
        Me.RadioButton_coilHelmet.Size = New System.Drawing.Size(97, 21)
        Me.RadioButton_coilHelmet.TabIndex = 4
        Me.RadioButton_coilHelmet.TabStop = True
        Me.RadioButton_coilHelmet.Tag = ""
        Me.RadioButton_coilHelmet.Text = "Coil Helmet"
        Me.RadioButton_coilHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsNova
        '
        Me.TabPage_arcaneHelmetsNova.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsNova.Controls.Add(Me.RadioButton_fluxHelmet)
        Me.TabPage_arcaneHelmetsNova.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsNova.Name = "TabPage_arcaneHelmetsNova"
        Me.TabPage_arcaneHelmetsNova.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsNova.TabIndex = 14
        Me.TabPage_arcaneHelmetsNova.Text = "Nova"
        '
        'RadioButton_fluxHelmet
        '
        Me.RadioButton_fluxHelmet.AutoSize = True
        Me.RadioButton_fluxHelmet.Checked = True
        Me.RadioButton_fluxHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_fluxHelmet.Name = "RadioButton_fluxHelmet"
        Me.RadioButton_fluxHelmet.Size = New System.Drawing.Size(99, 21)
        Me.RadioButton_fluxHelmet.TabIndex = 4
        Me.RadioButton_fluxHelmet.TabStop = True
        Me.RadioButton_fluxHelmet.Tag = ""
        Me.RadioButton_fluxHelmet.Text = "Flux Helmet"
        Me.RadioButton_fluxHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsNyx
        '
        Me.TabPage_arcaneHelmetsNyx.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsNyx.Controls.Add(Me.RadioButton_vespaHelmet)
        Me.TabPage_arcaneHelmetsNyx.Controls.Add(Me.RadioButton_menticideHelmet)
        Me.TabPage_arcaneHelmetsNyx.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsNyx.Name = "TabPage_arcaneHelmetsNyx"
        Me.TabPage_arcaneHelmetsNyx.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsNyx.TabIndex = 8
        Me.TabPage_arcaneHelmetsNyx.Text = "Nyx"
        '
        'RadioButton_vespaHelmet
        '
        Me.RadioButton_vespaHelmet.AutoSize = True
        Me.RadioButton_vespaHelmet.Location = New System.Drawing.Point(149, 25)
        Me.RadioButton_vespaHelmet.Name = "RadioButton_vespaHelmet"
        Me.RadioButton_vespaHelmet.Size = New System.Drawing.Size(114, 21)
        Me.RadioButton_vespaHelmet.TabIndex = 5
        Me.RadioButton_vespaHelmet.Tag = ""
        Me.RadioButton_vespaHelmet.Text = "Vespa Helmet"
        Me.RadioButton_vespaHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_menticideHelmet
        '
        Me.RadioButton_menticideHelmet.AutoSize = True
        Me.RadioButton_menticideHelmet.Checked = True
        Me.RadioButton_menticideHelmet.Location = New System.Drawing.Point(9, 25)
        Me.RadioButton_menticideHelmet.Name = "RadioButton_menticideHelmet"
        Me.RadioButton_menticideHelmet.Size = New System.Drawing.Size(134, 21)
        Me.RadioButton_menticideHelmet.TabIndex = 4
        Me.RadioButton_menticideHelmet.TabStop = True
        Me.RadioButton_menticideHelmet.Tag = ""
        Me.RadioButton_menticideHelmet.Text = "Menticide Helmet"
        Me.RadioButton_menticideHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsRhino
        '
        Me.TabPage_arcaneHelmetsRhino.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsRhino.Controls.Add(Me.RadioButton_vanguardHelmet)
        Me.TabPage_arcaneHelmetsRhino.Controls.Add(Me.RadioButton_thrak)
        Me.TabPage_arcaneHelmetsRhino.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsRhino.Name = "TabPage_arcaneHelmetsRhino"
        Me.TabPage_arcaneHelmetsRhino.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsRhino.TabIndex = 9
        Me.TabPage_arcaneHelmetsRhino.Text = "Rhino"
        '
        'RadioButton_vanguardHelmet
        '
        Me.RadioButton_vanguardHelmet.AutoSize = True
        Me.RadioButton_vanguardHelmet.Location = New System.Drawing.Point(128, 25)
        Me.RadioButton_vanguardHelmet.Name = "RadioButton_vanguardHelmet"
        Me.RadioButton_vanguardHelmet.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton_vanguardHelmet.TabIndex = 5
        Me.RadioButton_vanguardHelmet.Tag = ""
        Me.RadioButton_vanguardHelmet.Text = "Vanguard Helmet"
        Me.RadioButton_vanguardHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_thrak
        '
        Me.RadioButton_thrak.AutoSize = True
        Me.RadioButton_thrak.Checked = True
        Me.RadioButton_thrak.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_thrak.Name = "RadioButton_thrak"
        Me.RadioButton_thrak.Size = New System.Drawing.Size(111, 21)
        Me.RadioButton_thrak.TabIndex = 4
        Me.RadioButton_thrak.TabStop = True
        Me.RadioButton_thrak.Tag = ""
        Me.RadioButton_thrak.Text = "Thrak Helmet"
        Me.RadioButton_thrak.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsSaryn
        '
        Me.TabPage_arcaneHelmetsSaryn.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsSaryn.Controls.Add(Me.RadioButton_hemlockHelmet)
        Me.TabPage_arcaneHelmetsSaryn.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsSaryn.Name = "TabPage_arcaneHelmetsSaryn"
        Me.TabPage_arcaneHelmetsSaryn.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsSaryn.TabIndex = 10
        Me.TabPage_arcaneHelmetsSaryn.Text = "Saryn"
        '
        'RadioButton_hemlockHelmet
        '
        Me.RadioButton_hemlockHelmet.AutoSize = True
        Me.RadioButton_hemlockHelmet.Checked = True
        Me.RadioButton_hemlockHelmet.Location = New System.Drawing.Point(9, 25)
        Me.RadioButton_hemlockHelmet.Name = "RadioButton_hemlockHelmet"
        Me.RadioButton_hemlockHelmet.Size = New System.Drawing.Size(128, 21)
        Me.RadioButton_hemlockHelmet.TabIndex = 4
        Me.RadioButton_hemlockHelmet.TabStop = True
        Me.RadioButton_hemlockHelmet.Tag = ""
        Me.RadioButton_hemlockHelmet.Text = "Hemlock Helmet"
        Me.RadioButton_hemlockHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsTrinity
        '
        Me.TabPage_arcaneHelmetsTrinity.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsTrinity.Controls.Add(Me.RadioButton_meridianHelmet)
        Me.TabPage_arcaneHelmetsTrinity.Controls.Add(Me.RadioButton_auraHelmet)
        Me.TabPage_arcaneHelmetsTrinity.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsTrinity.Name = "TabPage_arcaneHelmetsTrinity"
        Me.TabPage_arcaneHelmetsTrinity.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsTrinity.TabIndex = 11
        Me.TabPage_arcaneHelmetsTrinity.Text = "Trinity"
        '
        'RadioButton_meridianHelmet
        '
        Me.RadioButton_meridianHelmet.AutoSize = True
        Me.RadioButton_meridianHelmet.Location = New System.Drawing.Point(121, 25)
        Me.RadioButton_meridianHelmet.Name = "RadioButton_meridianHelmet"
        Me.RadioButton_meridianHelmet.Size = New System.Drawing.Size(128, 21)
        Me.RadioButton_meridianHelmet.TabIndex = 5
        Me.RadioButton_meridianHelmet.Tag = ""
        Me.RadioButton_meridianHelmet.Text = "Maridian Helmet"
        Me.RadioButton_meridianHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_auraHelmet
        '
        Me.RadioButton_auraHelmet.AutoSize = True
        Me.RadioButton_auraHelmet.Checked = True
        Me.RadioButton_auraHelmet.Location = New System.Drawing.Point(11, 25)
        Me.RadioButton_auraHelmet.Name = "RadioButton_auraHelmet"
        Me.RadioButton_auraHelmet.Size = New System.Drawing.Size(104, 21)
        Me.RadioButton_auraHelmet.TabIndex = 4
        Me.RadioButton_auraHelmet.TabStop = True
        Me.RadioButton_auraHelmet.Tag = ""
        Me.RadioButton_auraHelmet.Text = "Aura Helmet"
        Me.RadioButton_auraHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsVauban
        '
        Me.TabPage_arcaneHelmetsVauban.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsVauban.Controls.Add(Me.RadioButton_espritHelmet)
        Me.TabPage_arcaneHelmetsVauban.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsVauban.Name = "TabPage_arcaneHelmetsVauban"
        Me.TabPage_arcaneHelmetsVauban.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsVauban.TabIndex = 12
        Me.TabPage_arcaneHelmetsVauban.Text = "Vauban"
        '
        'RadioButton_espritHelmet
        '
        Me.RadioButton_espritHelmet.AutoSize = True
        Me.RadioButton_espritHelmet.Checked = True
        Me.RadioButton_espritHelmet.Location = New System.Drawing.Point(9, 25)
        Me.RadioButton_espritHelmet.Name = "RadioButton_espritHelmet"
        Me.RadioButton_espritHelmet.Size = New System.Drawing.Size(110, 21)
        Me.RadioButton_espritHelmet.TabIndex = 4
        Me.RadioButton_espritHelmet.TabStop = True
        Me.RadioButton_espritHelmet.Tag = ""
        Me.RadioButton_espritHelmet.Text = "Esprit Helmet"
        Me.RadioButton_espritHelmet.UseVisualStyleBackColor = True
        '
        'TabPage_arcaneHelmetsVolt
        '
        Me.TabPage_arcaneHelmetsVolt.BackColor = System.Drawing.Color.White
        Me.TabPage_arcaneHelmetsVolt.Controls.Add(Me.RadioButton_stormHelmet)
        Me.TabPage_arcaneHelmetsVolt.Controls.Add(Me.RadioButton_pulseHelmet)
        Me.TabPage_arcaneHelmetsVolt.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_arcaneHelmetsVolt.Name = "TabPage_arcaneHelmetsVolt"
        Me.TabPage_arcaneHelmetsVolt.Size = New System.Drawing.Size(279, 53)
        Me.TabPage_arcaneHelmetsVolt.TabIndex = 13
        Me.TabPage_arcaneHelmetsVolt.Text = "Volt"
        '
        'RadioButton_stormHelmet
        '
        Me.RadioButton_stormHelmet.AutoSize = True
        Me.RadioButton_stormHelmet.Location = New System.Drawing.Point(124, 25)
        Me.RadioButton_stormHelmet.Name = "RadioButton_stormHelmet"
        Me.RadioButton_stormHelmet.Size = New System.Drawing.Size(111, 21)
        Me.RadioButton_stormHelmet.TabIndex = 5
        Me.RadioButton_stormHelmet.Tag = ""
        Me.RadioButton_stormHelmet.Text = "Storm Helmet"
        Me.RadioButton_stormHelmet.UseVisualStyleBackColor = True
        '
        'RadioButton_pulseHelmet
        '
        Me.RadioButton_pulseHelmet.AutoSize = True
        Me.RadioButton_pulseHelmet.Checked = True
        Me.RadioButton_pulseHelmet.Location = New System.Drawing.Point(9, 25)
        Me.RadioButton_pulseHelmet.Name = "RadioButton_pulseHelmet"
        Me.RadioButton_pulseHelmet.Size = New System.Drawing.Size(109, 21)
        Me.RadioButton_pulseHelmet.TabIndex = 4
        Me.RadioButton_pulseHelmet.TabStop = True
        Me.RadioButton_pulseHelmet.Tag = ""
        Me.RadioButton_pulseHelmet.Text = "Pulse Helmet"
        Me.RadioButton_pulseHelmet.UseVisualStyleBackColor = True
        '
        'CheckBox_oversheilds
        '
        Me.CheckBox_oversheilds.AutoSize = True
        Me.CheckBox_oversheilds.Enabled = False
        Me.CheckBox_oversheilds.Location = New System.Drawing.Point(499, 332)
        Me.CheckBox_oversheilds.Name = "CheckBox_oversheilds"
        Me.CheckBox_oversheilds.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox_oversheilds.TabIndex = 115
        Me.CheckBox_oversheilds.Tag = "GroupBox_oversheilds"
        Me.CheckBox_oversheilds.Text = "Oversheilds"
        Me.CheckBox_oversheilds.UseVisualStyleBackColor = True
        '
        'GroupBox_oversheilds
        '
        Me.GroupBox_oversheilds.Controls.Add(Me.NumericUpDown_oversheilds)
        Me.GroupBox_oversheilds.Enabled = False
        Me.GroupBox_oversheilds.Location = New System.Drawing.Point(487, 332)
        Me.GroupBox_oversheilds.Name = "GroupBox_oversheilds"
        Me.GroupBox_oversheilds.Size = New System.Drawing.Size(281, 59)
        Me.GroupBox_oversheilds.TabIndex = 116
        Me.GroupBox_oversheilds.TabStop = False
        Me.GroupBox_oversheilds.Text = "  "
        '
        'NumericUpDown_oversheilds
        '
        Me.NumericUpDown_oversheilds.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_oversheilds.Location = New System.Drawing.Point(10, 27)
        Me.NumericUpDown_oversheilds.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.NumericUpDown_oversheilds.Name = "NumericUpDown_oversheilds"
        Me.NumericUpDown_oversheilds.Size = New System.Drawing.Size(265, 23)
        Me.NumericUpDown_oversheilds.TabIndex = 50
        '
        'CheckBox_focus
        '
        Me.CheckBox_focus.AutoSize = True
        Me.CheckBox_focus.Enabled = False
        Me.CheckBox_focus.Location = New System.Drawing.Point(494, 154)
        Me.CheckBox_focus.Name = "CheckBox_focus"
        Me.CheckBox_focus.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.CheckBox_focus.Size = New System.Drawing.Size(69, 21)
        Me.CheckBox_focus.TabIndex = 112
        Me.CheckBox_focus.Tag = "GroupBox_focus"
        Me.CheckBox_focus.Text = "Focus"
        Me.CheckBox_focus.UseVisualStyleBackColor = True
        '
        'CheckBox_abilities
        '
        Me.CheckBox_abilities.AutoSize = True
        Me.CheckBox_abilities.Enabled = False
        Me.CheckBox_abilities.Location = New System.Drawing.Point(492, 35)
        Me.CheckBox_abilities.Name = "CheckBox_abilities"
        Me.CheckBox_abilities.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.CheckBox_abilities.Size = New System.Drawing.Size(79, 21)
        Me.CheckBox_abilities.TabIndex = 58
        Me.CheckBox_abilities.Tag = "CustomTabControl_abilitys"
        Me.CheckBox_abilities.Text = "Abilities"
        Me.CheckBox_abilities.UseVisualStyleBackColor = True
        '
        'CheckBox_dragonKeys
        '
        Me.CheckBox_dragonKeys.AutoSize = True
        Me.CheckBox_dragonKeys.Enabled = False
        Me.CheckBox_dragonKeys.Location = New System.Drawing.Point(259, 397)
        Me.CheckBox_dragonKeys.Name = "CheckBox_dragonKeys"
        Me.CheckBox_dragonKeys.Size = New System.Drawing.Size(109, 21)
        Me.CheckBox_dragonKeys.TabIndex = 55
        Me.CheckBox_dragonKeys.Tag = "GroupBox_dragonKeys"
        Me.CheckBox_dragonKeys.Text = "Dragon Keys"
        Me.CheckBox_dragonKeys.UseVisualStyleBackColor = True
        '
        'CheckBox_arcanes
        '
        Me.CheckBox_arcanes.AutoSize = True
        Me.CheckBox_arcanes.Enabled = False
        Me.CheckBox_arcanes.Location = New System.Drawing.Point(20, 397)
        Me.CheckBox_arcanes.Name = "CheckBox_arcanes"
        Me.CheckBox_arcanes.Size = New System.Drawing.Size(79, 21)
        Me.CheckBox_arcanes.TabIndex = 50
        Me.CheckBox_arcanes.Tag = "GroupBox_arcanes"
        Me.CheckBox_arcanes.Text = "Arcanes"
        Me.CheckBox_arcanes.UseVisualStyleBackColor = True
        '
        'GroupBox_dragonKeys
        '
        Me.GroupBox_dragonKeys.Controls.Add(Me.RadioButton_decayingKey)
        Me.GroupBox_dragonKeys.Controls.Add(Me.RadioButton_bleedingKey)
        Me.GroupBox_dragonKeys.Enabled = False
        Me.GroupBox_dragonKeys.Location = New System.Drawing.Point(247, 397)
        Me.GroupBox_dragonKeys.Name = "GroupBox_dragonKeys"
        Me.GroupBox_dragonKeys.Size = New System.Drawing.Size(233, 84)
        Me.GroupBox_dragonKeys.TabIndex = 109
        Me.GroupBox_dragonKeys.TabStop = False
        Me.GroupBox_dragonKeys.Text = "  "
        '
        'RadioButton_decayingKey
        '
        Me.RadioButton_decayingKey.AutoSize = True
        Me.RadioButton_decayingKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_decayingKey.Location = New System.Drawing.Point(12, 54)
        Me.RadioButton_decayingKey.Name = "RadioButton_decayingKey"
        Me.RadioButton_decayingKey.Size = New System.Drawing.Size(113, 21)
        Me.RadioButton_decayingKey.TabIndex = 57
        Me.RadioButton_decayingKey.TabStop = True
        Me.RadioButton_decayingKey.Text = "Decaying Key"
        Me.RadioButton_decayingKey.UseVisualStyleBackColor = True
        '
        'RadioButton_bleedingKey
        '
        Me.RadioButton_bleedingKey.AutoSize = True
        Me.RadioButton_bleedingKey.Checked = True
        Me.RadioButton_bleedingKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_bleedingKey.Location = New System.Drawing.Point(12, 27)
        Me.RadioButton_bleedingKey.Name = "RadioButton_bleedingKey"
        Me.RadioButton_bleedingKey.Size = New System.Drawing.Size(109, 21)
        Me.RadioButton_bleedingKey.TabIndex = 56
        Me.RadioButton_bleedingKey.TabStop = True
        Me.RadioButton_bleedingKey.Text = "Bleeding Key"
        Me.RadioButton_bleedingKey.UseVisualStyleBackColor = True
        '
        'GroupBox_arcanes
        '
        Me.GroupBox_arcanes.Controls.Add(Me.CheckBox_arcaneGuardian)
        Me.GroupBox_arcanes.Controls.Add(Me.NumericUpDown_arcaneUltimatum)
        Me.GroupBox_arcanes.Controls.Add(Me.NumericUpDown_arcaneGuardian)
        Me.GroupBox_arcanes.Controls.Add(Me.CheckBox_arcaneUltimatum)
        Me.GroupBox_arcanes.Enabled = False
        Me.GroupBox_arcanes.Location = New System.Drawing.Point(8, 397)
        Me.GroupBox_arcanes.Name = "GroupBox_arcanes"
        Me.GroupBox_arcanes.Size = New System.Drawing.Size(233, 84)
        Me.GroupBox_arcanes.TabIndex = 107
        Me.GroupBox_arcanes.TabStop = False
        Me.GroupBox_arcanes.Text = "  "
        '
        'CheckBox_arcaneGuardian
        '
        Me.CheckBox_arcaneGuardian.AutoSize = True
        Me.CheckBox_arcaneGuardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_arcaneGuardian.Location = New System.Drawing.Point(12, 24)
        Me.CheckBox_arcaneGuardian.Name = "CheckBox_arcaneGuardian"
        Me.CheckBox_arcaneGuardian.Size = New System.Drawing.Size(139, 21)
        Me.CheckBox_arcaneGuardian.TabIndex = 51
        Me.CheckBox_arcaneGuardian.Text = "Arcane Guardian:"
        Me.CheckBox_arcaneGuardian.UseVisualStyleBackColor = True
        '
        'NumericUpDown_arcaneUltimatum
        '
        Me.NumericUpDown_arcaneUltimatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_arcaneUltimatum.Location = New System.Drawing.Point(159, 49)
        Me.NumericUpDown_arcaneUltimatum.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown_arcaneUltimatum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_arcaneUltimatum.Name = "NumericUpDown_arcaneUltimatum"
        Me.NumericUpDown_arcaneUltimatum.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_arcaneUltimatum.TabIndex = 54
        Me.NumericUpDown_arcaneUltimatum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown_arcaneGuardian
        '
        Me.NumericUpDown_arcaneGuardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_arcaneGuardian.Location = New System.Drawing.Point(159, 23)
        Me.NumericUpDown_arcaneGuardian.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown_arcaneGuardian.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_arcaneGuardian.Name = "NumericUpDown_arcaneGuardian"
        Me.NumericUpDown_arcaneGuardian.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_arcaneGuardian.TabIndex = 52
        Me.NumericUpDown_arcaneGuardian.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckBox_arcaneUltimatum
        '
        Me.CheckBox_arcaneUltimatum.AutoSize = True
        Me.CheckBox_arcaneUltimatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_arcaneUltimatum.Location = New System.Drawing.Point(12, 50)
        Me.CheckBox_arcaneUltimatum.Name = "CheckBox_arcaneUltimatum"
        Me.CheckBox_arcaneUltimatum.Size = New System.Drawing.Size(142, 21)
        Me.CheckBox_arcaneUltimatum.TabIndex = 53
        Me.CheckBox_arcaneUltimatum.Text = "Arcane Ultimatum:"
        Me.CheckBox_arcaneUltimatum.UseVisualStyleBackColor = True
        '
        'CheckBox_miscellaneous
        '
        Me.CheckBox_miscellaneous.AutoSize = True
        Me.CheckBox_miscellaneous.Enabled = False
        Me.CheckBox_miscellaneous.Location = New System.Drawing.Point(259, 36)
        Me.CheckBox_miscellaneous.Name = "CheckBox_miscellaneous"
        Me.CheckBox_miscellaneous.Size = New System.Drawing.Size(116, 21)
        Me.CheckBox_miscellaneous.TabIndex = 30
        Me.CheckBox_miscellaneous.Tag = "GroupBox_miscellaneous"
        Me.CheckBox_miscellaneous.Text = "Miscellaneous"
        Me.CheckBox_miscellaneous.UseVisualStyleBackColor = True
        '
        'GroupBox_miscellaneous
        '
        Me.GroupBox_miscellaneous.Controls.Add(Me.NumericUpDown_enduranceDrift)
        Me.GroupBox_miscellaneous.Controls.Add(Me.NumericUpDown_flow)
        Me.GroupBox_miscellaneous.Controls.Add(Me.CheckBox_flow)
        Me.GroupBox_miscellaneous.Controls.Add(Me.CheckBox_enduranceDrift)
        Me.GroupBox_miscellaneous.Controls.Add(Me.CheckBox_coactionDrift)
        Me.GroupBox_miscellaneous.Controls.Add(Me.NumericUpDown_coactionDrift)
        Me.GroupBox_miscellaneous.Enabled = False
        Me.GroupBox_miscellaneous.Location = New System.Drawing.Point(247, 36)
        Me.GroupBox_miscellaneous.Name = "GroupBox_miscellaneous"
        Me.GroupBox_miscellaneous.Size = New System.Drawing.Size(233, 114)
        Me.GroupBox_miscellaneous.TabIndex = 105
        Me.GroupBox_miscellaneous.TabStop = False
        Me.GroupBox_miscellaneous.Text = "  "
        '
        'NumericUpDown_enduranceDrift
        '
        Me.NumericUpDown_enduranceDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_enduranceDrift.Location = New System.Drawing.Point(158, 52)
        Me.NumericUpDown_enduranceDrift.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_enduranceDrift.Name = "NumericUpDown_enduranceDrift"
        Me.NumericUpDown_enduranceDrift.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_enduranceDrift.TabIndex = 34
        '
        'NumericUpDown_flow
        '
        Me.NumericUpDown_flow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_flow.Location = New System.Drawing.Point(158, 78)
        Me.NumericUpDown_flow.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_flow.Name = "NumericUpDown_flow"
        Me.NumericUpDown_flow.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_flow.TabIndex = 36
        '
        'CheckBox_flow
        '
        Me.CheckBox_flow.AutoSize = True
        Me.CheckBox_flow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_flow.Location = New System.Drawing.Point(12, 79)
        Me.CheckBox_flow.Name = "CheckBox_flow"
        Me.CheckBox_flow.Size = New System.Drawing.Size(59, 21)
        Me.CheckBox_flow.TabIndex = 35
        Me.CheckBox_flow.Text = "Flow:"
        Me.CheckBox_flow.UseVisualStyleBackColor = True
        '
        'CheckBox_enduranceDrift
        '
        Me.CheckBox_enduranceDrift.AutoSize = True
        Me.CheckBox_enduranceDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_enduranceDrift.Location = New System.Drawing.Point(12, 53)
        Me.CheckBox_enduranceDrift.Name = "CheckBox_enduranceDrift"
        Me.CheckBox_enduranceDrift.Size = New System.Drawing.Size(130, 21)
        Me.CheckBox_enduranceDrift.TabIndex = 33
        Me.CheckBox_enduranceDrift.Text = "Endurance Drift:"
        Me.CheckBox_enduranceDrift.UseVisualStyleBackColor = True
        '
        'CheckBox_coactionDrift
        '
        Me.CheckBox_coactionDrift.AutoSize = True
        Me.CheckBox_coactionDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_coactionDrift.Location = New System.Drawing.Point(12, 27)
        Me.CheckBox_coactionDrift.Name = "CheckBox_coactionDrift"
        Me.CheckBox_coactionDrift.Size = New System.Drawing.Size(116, 21)
        Me.CheckBox_coactionDrift.TabIndex = 31
        Me.CheckBox_coactionDrift.Text = "Coaction Drift:"
        Me.CheckBox_coactionDrift.UseVisualStyleBackColor = True
        '
        'NumericUpDown_coactionDrift
        '
        Me.NumericUpDown_coactionDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_coactionDrift.Location = New System.Drawing.Point(158, 26)
        Me.NumericUpDown_coactionDrift.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_coactionDrift.Name = "NumericUpDown_coactionDrift"
        Me.NumericUpDown_coactionDrift.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_coactionDrift.TabIndex = 32
        '
        'CheckBox_power
        '
        Me.CheckBox_power.AutoSize = True
        Me.CheckBox_power.Enabled = False
        Me.CheckBox_power.Location = New System.Drawing.Point(259, 156)
        Me.CheckBox_power.Name = "CheckBox_power"
        Me.CheckBox_power.Size = New System.Drawing.Size(66, 21)
        Me.CheckBox_power.TabIndex = 37
        Me.CheckBox_power.Tag = "GroupBox_power"
        Me.CheckBox_power.Text = "Power"
        Me.CheckBox_power.UseVisualStyleBackColor = True
        '
        'GroupBox_power
        '
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_overextended)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_overextended)
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_transientFortitude)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_transientFortitude)
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_intensify)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_intensify)
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_powerDrift)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_powerDrift)
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_blindRage)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_blindRage)
        Me.GroupBox_power.Controls.Add(Me.NumericUpDown_energyConversion)
        Me.GroupBox_power.Controls.Add(Me.CheckBox_energyConversion)
        Me.GroupBox_power.Enabled = False
        Me.GroupBox_power.Location = New System.Drawing.Point(247, 156)
        Me.GroupBox_power.Name = "GroupBox_power"
        Me.GroupBox_power.Size = New System.Drawing.Size(233, 235)
        Me.GroupBox_power.TabIndex = 103
        Me.GroupBox_power.TabStop = False
        Me.GroupBox_power.Text = "  "
        '
        'NumericUpDown_overextended
        '
        Me.NumericUpDown_overextended.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_overextended.Location = New System.Drawing.Point(158, 130)
        Me.NumericUpDown_overextended.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_overextended.Name = "NumericUpDown_overextended"
        Me.NumericUpDown_overextended.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_overextended.TabIndex = 47
        '
        'CheckBox_overextended
        '
        Me.CheckBox_overextended.AutoSize = True
        Me.CheckBox_overextended.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_overextended.Location = New System.Drawing.Point(12, 131)
        Me.CheckBox_overextended.Name = "CheckBox_overextended"
        Me.CheckBox_overextended.Size = New System.Drawing.Size(120, 21)
        Me.CheckBox_overextended.TabIndex = 46
        Me.CheckBox_overextended.Text = "Overextended:"
        Me.CheckBox_overextended.UseVisualStyleBackColor = True
        '
        'NumericUpDown_transientFortitude
        '
        Me.NumericUpDown_transientFortitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_transientFortitude.Location = New System.Drawing.Point(158, 104)
        Me.NumericUpDown_transientFortitude.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_transientFortitude.Name = "NumericUpDown_transientFortitude"
        Me.NumericUpDown_transientFortitude.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_transientFortitude.TabIndex = 45
        '
        'CheckBox_transientFortitude
        '
        Me.CheckBox_transientFortitude.AutoSize = True
        Me.CheckBox_transientFortitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_transientFortitude.Location = New System.Drawing.Point(12, 105)
        Me.CheckBox_transientFortitude.Name = "CheckBox_transientFortitude"
        Me.CheckBox_transientFortitude.Size = New System.Drawing.Size(151, 21)
        Me.CheckBox_transientFortitude.TabIndex = 44
        Me.CheckBox_transientFortitude.Text = "Transient Fortitude:"
        Me.CheckBox_transientFortitude.UseVisualStyleBackColor = True
        '
        'NumericUpDown_intensify
        '
        Me.NumericUpDown_intensify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_intensify.Location = New System.Drawing.Point(158, 78)
        Me.NumericUpDown_intensify.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_intensify.Name = "NumericUpDown_intensify"
        Me.NumericUpDown_intensify.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_intensify.TabIndex = 43
        '
        'CheckBox_intensify
        '
        Me.CheckBox_intensify.AutoSize = True
        Me.CheckBox_intensify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_intensify.Location = New System.Drawing.Point(12, 79)
        Me.CheckBox_intensify.Name = "CheckBox_intensify"
        Me.CheckBox_intensify.Size = New System.Drawing.Size(83, 21)
        Me.CheckBox_intensify.TabIndex = 42
        Me.CheckBox_intensify.Text = "Intensify:"
        Me.CheckBox_intensify.UseVisualStyleBackColor = True
        '
        'NumericUpDown_powerDrift
        '
        Me.NumericUpDown_powerDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_powerDrift.Location = New System.Drawing.Point(158, 156)
        Me.NumericUpDown_powerDrift.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_powerDrift.Name = "NumericUpDown_powerDrift"
        Me.NumericUpDown_powerDrift.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_powerDrift.TabIndex = 49
        '
        'CheckBox_powerDrift
        '
        Me.CheckBox_powerDrift.AutoSize = True
        Me.CheckBox_powerDrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_powerDrift.Location = New System.Drawing.Point(12, 157)
        Me.CheckBox_powerDrift.Name = "CheckBox_powerDrift"
        Me.CheckBox_powerDrift.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox_powerDrift.TabIndex = 48
        Me.CheckBox_powerDrift.Text = "Power Drift:"
        Me.CheckBox_powerDrift.UseVisualStyleBackColor = True
        '
        'NumericUpDown_blindRage
        '
        Me.NumericUpDown_blindRage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_blindRage.Location = New System.Drawing.Point(158, 26)
        Me.NumericUpDown_blindRage.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_blindRage.Name = "NumericUpDown_blindRage"
        Me.NumericUpDown_blindRage.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_blindRage.TabIndex = 39
        '
        'CheckBox_blindRage
        '
        Me.CheckBox_blindRage.AutoSize = True
        Me.CheckBox_blindRage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_blindRage.Location = New System.Drawing.Point(12, 27)
        Me.CheckBox_blindRage.Name = "CheckBox_blindRage"
        Me.CheckBox_blindRage.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox_blindRage.TabIndex = 38
        Me.CheckBox_blindRage.Text = "Blind Rage:"
        Me.CheckBox_blindRage.UseVisualStyleBackColor = True
        '
        'NumericUpDown_energyConversion
        '
        Me.NumericUpDown_energyConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_energyConversion.Location = New System.Drawing.Point(158, 52)
        Me.NumericUpDown_energyConversion.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_energyConversion.Name = "NumericUpDown_energyConversion"
        Me.NumericUpDown_energyConversion.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_energyConversion.TabIndex = 41
        '
        'CheckBox_energyConversion
        '
        Me.CheckBox_energyConversion.AutoSize = True
        Me.CheckBox_energyConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_energyConversion.Location = New System.Drawing.Point(12, 52)
        Me.CheckBox_energyConversion.Name = "CheckBox_energyConversion"
        Me.CheckBox_energyConversion.Size = New System.Drawing.Size(151, 21)
        Me.CheckBox_energyConversion.TabIndex = 40
        Me.CheckBox_energyConversion.Text = "Energy Conversion:"
        Me.CheckBox_energyConversion.UseVisualStyleBackColor = True
        '
        'CheckBox_survivability
        '
        Me.CheckBox_survivability.AutoSize = True
        Me.CheckBox_survivability.Enabled = False
        Me.CheckBox_survivability.Location = New System.Drawing.Point(20, 156)
        Me.CheckBox_survivability.Name = "CheckBox_survivability"
        Me.CheckBox_survivability.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox_survivability.TabIndex = 14
        Me.CheckBox_survivability.Tag = "GroupBox_survivability"
        Me.CheckBox_survivability.Text = "Survivability"
        Me.CheckBox_survivability.UseVisualStyleBackColor = True
        '
        'GroupBox_survivability
        '
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_armoredAgility)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_steelFiber)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_armoredAgility)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_vigor)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_healthConversionStacks)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_quickThinking)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_redirection)
        Me.GroupBox_survivability.Controls.Add(Me.Label_healthConversionStacks)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_quickThinking)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_vitality)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_healthConversion)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_vigor)
        Me.GroupBox_survivability.Controls.Add(Me.NumericUpDown_steelFiber)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_healthConversion)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_redirection)
        Me.GroupBox_survivability.Controls.Add(Me.CheckBox_vitality)
        Me.GroupBox_survivability.Enabled = False
        Me.GroupBox_survivability.Location = New System.Drawing.Point(8, 156)
        Me.GroupBox_survivability.Name = "GroupBox_survivability"
        Me.GroupBox_survivability.Size = New System.Drawing.Size(233, 235)
        Me.GroupBox_survivability.TabIndex = 101
        Me.GroupBox_survivability.TabStop = False
        Me.GroupBox_survivability.Text = "  "
        '
        'NumericUpDown_armoredAgility
        '
        Me.NumericUpDown_armoredAgility.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_armoredAgility.Location = New System.Drawing.Point(159, 130)
        Me.NumericUpDown_armoredAgility.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_armoredAgility.Name = "NumericUpDown_armoredAgility"
        Me.NumericUpDown_armoredAgility.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_armoredAgility.TabIndex = 24
        '
        'CheckBox_steelFiber
        '
        Me.CheckBox_steelFiber.AutoSize = True
        Me.CheckBox_steelFiber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_steelFiber.Location = New System.Drawing.Point(12, 27)
        Me.CheckBox_steelFiber.Name = "CheckBox_steelFiber"
        Me.CheckBox_steelFiber.Size = New System.Drawing.Size(99, 21)
        Me.CheckBox_steelFiber.TabIndex = 15
        Me.CheckBox_steelFiber.Text = "Steel Fiber:"
        Me.CheckBox_steelFiber.UseVisualStyleBackColor = True
        '
        'CheckBox_armoredAgility
        '
        Me.CheckBox_armoredAgility.AutoSize = True
        Me.CheckBox_armoredAgility.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_armoredAgility.Location = New System.Drawing.Point(12, 131)
        Me.CheckBox_armoredAgility.Name = "CheckBox_armoredAgility"
        Me.CheckBox_armoredAgility.Size = New System.Drawing.Size(126, 21)
        Me.CheckBox_armoredAgility.TabIndex = 23
        Me.CheckBox_armoredAgility.Text = "Armored Agility:"
        Me.CheckBox_armoredAgility.UseVisualStyleBackColor = True
        '
        'NumericUpDown_vigor
        '
        Me.NumericUpDown_vigor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_vigor.Location = New System.Drawing.Point(159, 104)
        Me.NumericUpDown_vigor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_vigor.Name = "NumericUpDown_vigor"
        Me.NumericUpDown_vigor.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_vigor.TabIndex = 22
        '
        'NumericUpDown_healthConversionStacks
        '
        Me.NumericUpDown_healthConversionStacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_healthConversionStacks.Location = New System.Drawing.Point(159, 204)
        Me.NumericUpDown_healthConversionStacks.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown_healthConversionStacks.Name = "NumericUpDown_healthConversionStacks"
        Me.NumericUpDown_healthConversionStacks.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_healthConversionStacks.TabIndex = 29
        '
        'NumericUpDown_quickThinking
        '
        Me.NumericUpDown_quickThinking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_quickThinking.Location = New System.Drawing.Point(159, 156)
        Me.NumericUpDown_quickThinking.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_quickThinking.Name = "NumericUpDown_quickThinking"
        Me.NumericUpDown_quickThinking.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_quickThinking.TabIndex = 26
        '
        'NumericUpDown_redirection
        '
        Me.NumericUpDown_redirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_redirection.Location = New System.Drawing.Point(159, 78)
        Me.NumericUpDown_redirection.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_redirection.Name = "NumericUpDown_redirection"
        Me.NumericUpDown_redirection.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_redirection.TabIndex = 20
        '
        'Label_healthConversionStacks
        '
        Me.Label_healthConversionStacks.AutoSize = True
        Me.Label_healthConversionStacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_healthConversionStacks.Location = New System.Drawing.Point(100, 206)
        Me.Label_healthConversionStacks.Name = "Label_healthConversionStacks"
        Me.Label_healthConversionStacks.Size = New System.Drawing.Size(54, 17)
        Me.Label_healthConversionStacks.TabIndex = 63
        Me.Label_healthConversionStacks.Text = "Stacks:"
        '
        'CheckBox_quickThinking
        '
        Me.CheckBox_quickThinking.AutoSize = True
        Me.CheckBox_quickThinking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_quickThinking.Location = New System.Drawing.Point(12, 157)
        Me.CheckBox_quickThinking.Name = "CheckBox_quickThinking"
        Me.CheckBox_quickThinking.Size = New System.Drawing.Size(125, 21)
        Me.CheckBox_quickThinking.TabIndex = 25
        Me.CheckBox_quickThinking.Text = "Quick Thinking:"
        Me.CheckBox_quickThinking.UseVisualStyleBackColor = True
        '
        'NumericUpDown_vitality
        '
        Me.NumericUpDown_vitality.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_vitality.Location = New System.Drawing.Point(159, 52)
        Me.NumericUpDown_vitality.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_vitality.Name = "NumericUpDown_vitality"
        Me.NumericUpDown_vitality.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_vitality.TabIndex = 18
        '
        'NumericUpDown_healthConversion
        '
        Me.NumericUpDown_healthConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_healthConversion.Location = New System.Drawing.Point(159, 182)
        Me.NumericUpDown_healthConversion.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_healthConversion.Name = "NumericUpDown_healthConversion"
        Me.NumericUpDown_healthConversion.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_healthConversion.TabIndex = 28
        '
        'CheckBox_vigor
        '
        Me.CheckBox_vigor.AutoSize = True
        Me.CheckBox_vigor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_vigor.Location = New System.Drawing.Point(12, 105)
        Me.CheckBox_vigor.Name = "CheckBox_vigor"
        Me.CheckBox_vigor.Size = New System.Drawing.Size(64, 21)
        Me.CheckBox_vigor.TabIndex = 21
        Me.CheckBox_vigor.Text = "Vigor:"
        Me.CheckBox_vigor.UseVisualStyleBackColor = True
        '
        'NumericUpDown_steelFiber
        '
        Me.NumericUpDown_steelFiber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_steelFiber.Location = New System.Drawing.Point(159, 26)
        Me.NumericUpDown_steelFiber.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_steelFiber.Name = "NumericUpDown_steelFiber"
        Me.NumericUpDown_steelFiber.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_steelFiber.TabIndex = 16
        '
        'CheckBox_healthConversion
        '
        Me.CheckBox_healthConversion.AutoSize = True
        Me.CheckBox_healthConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_healthConversion.Location = New System.Drawing.Point(12, 183)
        Me.CheckBox_healthConversion.Name = "CheckBox_healthConversion"
        Me.CheckBox_healthConversion.Size = New System.Drawing.Size(147, 21)
        Me.CheckBox_healthConversion.TabIndex = 27
        Me.CheckBox_healthConversion.Text = "Health Conversion:"
        Me.CheckBox_healthConversion.UseVisualStyleBackColor = True
        '
        'CheckBox_redirection
        '
        Me.CheckBox_redirection.AutoSize = True
        Me.CheckBox_redirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_redirection.Location = New System.Drawing.Point(12, 79)
        Me.CheckBox_redirection.Name = "CheckBox_redirection"
        Me.CheckBox_redirection.Size = New System.Drawing.Size(103, 21)
        Me.CheckBox_redirection.TabIndex = 19
        Me.CheckBox_redirection.Text = "Redirection:"
        Me.CheckBox_redirection.UseVisualStyleBackColor = True
        '
        'CheckBox_vitality
        '
        Me.CheckBox_vitality.AutoSize = True
        Me.CheckBox_vitality.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_vitality.Location = New System.Drawing.Point(12, 53)
        Me.CheckBox_vitality.Name = "CheckBox_vitality"
        Me.CheckBox_vitality.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox_vitality.TabIndex = 17
        Me.CheckBox_vitality.Text = "Vitality:"
        Me.CheckBox_vitality.UseVisualStyleBackColor = True
        '
        'CheckBox_aura
        '
        Me.CheckBox_aura.AutoSize = True
        Me.CheckBox_aura.Enabled = False
        Me.CheckBox_aura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_aura.Location = New System.Drawing.Point(20, 36)
        Me.CheckBox_aura.Name = "CheckBox_aura"
        Me.CheckBox_aura.Size = New System.Drawing.Size(57, 21)
        Me.CheckBox_aura.TabIndex = 3
        Me.CheckBox_aura.Tag = "GroupBox_aura"
        Me.CheckBox_aura.Text = "Aura"
        Me.CheckBox_aura.UseVisualStyleBackColor = True
        '
        'GroupBox_aura
        '
        Me.GroupBox_aura.Controls.Add(Me.NumericUpDown_growingPower)
        Me.GroupBox_aura.Controls.Add(Me.RadioButton_growingPower)
        Me.GroupBox_aura.Controls.Add(Me.NumericUpDown_standUnited)
        Me.GroupBox_aura.Controls.Add(Me.RadioButton_standUnited)
        Me.GroupBox_aura.Controls.Add(Me.NumericUpDown_physique)
        Me.GroupBox_aura.Controls.Add(Me.RadioButton_physique)
        Me.GroupBox_aura.Enabled = False
        Me.GroupBox_aura.Location = New System.Drawing.Point(8, 36)
        Me.GroupBox_aura.Name = "GroupBox_aura"
        Me.GroupBox_aura.Size = New System.Drawing.Size(233, 114)
        Me.GroupBox_aura.TabIndex = 3
        Me.GroupBox_aura.TabStop = False
        Me.GroupBox_aura.Text = "  "
        '
        'NumericUpDown_growingPower
        '
        Me.NumericUpDown_growingPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_growingPower.Location = New System.Drawing.Point(159, 26)
        Me.NumericUpDown_growingPower.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_growingPower.Name = "NumericUpDown_growingPower"
        Me.NumericUpDown_growingPower.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_growingPower.TabIndex = 9
        '
        'RadioButton_growingPower
        '
        Me.RadioButton_growingPower.AutoSize = True
        Me.RadioButton_growingPower.Checked = True
        Me.RadioButton_growingPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_growingPower.Location = New System.Drawing.Point(12, 26)
        Me.RadioButton_growingPower.Name = "RadioButton_growingPower"
        Me.RadioButton_growingPower.Size = New System.Drawing.Size(125, 21)
        Me.RadioButton_growingPower.TabIndex = 8
        Me.RadioButton_growingPower.TabStop = True
        Me.RadioButton_growingPower.Text = "Growing Power:"
        Me.RadioButton_growingPower.UseVisualStyleBackColor = True
        '
        'NumericUpDown_standUnited
        '
        Me.NumericUpDown_standUnited.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_standUnited.Location = New System.Drawing.Point(159, 78)
        Me.NumericUpDown_standUnited.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_standUnited.Name = "NumericUpDown_standUnited"
        Me.NumericUpDown_standUnited.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_standUnited.TabIndex = 13
        '
        'RadioButton_standUnited
        '
        Me.RadioButton_standUnited.AutoSize = True
        Me.RadioButton_standUnited.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_standUnited.Location = New System.Drawing.Point(12, 78)
        Me.RadioButton_standUnited.Name = "RadioButton_standUnited"
        Me.RadioButton_standUnited.Size = New System.Drawing.Size(112, 21)
        Me.RadioButton_standUnited.TabIndex = 12
        Me.RadioButton_standUnited.Text = "Stand United:"
        Me.RadioButton_standUnited.UseVisualStyleBackColor = True
        '
        'NumericUpDown_physique
        '
        Me.NumericUpDown_physique.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_physique.Location = New System.Drawing.Point(159, 52)
        Me.NumericUpDown_physique.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_physique.Name = "NumericUpDown_physique"
        Me.NumericUpDown_physique.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_physique.TabIndex = 11
        '
        'RadioButton_physique
        '
        Me.RadioButton_physique.AutoSize = True
        Me.RadioButton_physique.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_physique.Location = New System.Drawing.Point(12, 52)
        Me.RadioButton_physique.Name = "RadioButton_physique"
        Me.RadioButton_physique.Size = New System.Drawing.Size(88, 21)
        Me.RadioButton_physique.TabIndex = 10
        Me.RadioButton_physique.Text = "Physique:"
        Me.RadioButton_physique.UseVisualStyleBackColor = True
        '
        'CheckBox_isUmbra
        '
        Me.CheckBox_isUmbra.AutoSize = True
        Me.CheckBox_isUmbra.Enabled = False
        Me.CheckBox_isUmbra.Location = New System.Drawing.Point(328, 9)
        Me.CheckBox_isUmbra.Name = "CheckBox_isUmbra"
        Me.CheckBox_isUmbra.Size = New System.Drawing.Size(69, 21)
        Me.CheckBox_isUmbra.TabIndex = 2
        Me.CheckBox_isUmbra.Text = "Umbra"
        Me.CheckBox_isUmbra.UseVisualStyleBackColor = True
        '
        'ComboBox_warframes
        '
        Me.ComboBox_warframes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_warframes.FormattingEnabled = True
        Me.ComboBox_warframes.Items.AddRange(New Object() {"Select a Warframe", "Ash", "Atlas", "Banshee", "Chroma", "Ember", "Equinox", "Excalibur", "Frost", "Harrow", "Hydroid", "Inaros", "Ivara", "Limbo", "Loki", "Mag", "Mesa", "Mirage", "Nekros", "Nezha", "Nidus", "Nova", "Nyx", "Oberon", "Octavia", "Rhino", "Saryn", "Titania", "Trinity", "Valkyr", "Vauban", "Volt", "Wukong", "Zephyr"})
        Me.ComboBox_warframes.Location = New System.Drawing.Point(8, 6)
        Me.ComboBox_warframes.Name = "ComboBox_warframes"
        Me.ComboBox_warframes.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox_warframes.TabIndex = 0
        '
        'CheckBox_isPrime
        '
        Me.CheckBox_isPrime.AutoSize = True
        Me.CheckBox_isPrime.Enabled = False
        Me.CheckBox_isPrime.Location = New System.Drawing.Point(259, 9)
        Me.CheckBox_isPrime.Name = "CheckBox_isPrime"
        Me.CheckBox_isPrime.Size = New System.Drawing.Size(63, 21)
        Me.CheckBox_isPrime.TabIndex = 1
        Me.CheckBox_isPrime.Text = "Prime"
        Me.CheckBox_isPrime.UseVisualStyleBackColor = True
        '
        'CustomTabControl_abilitys
        '
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesDefault)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesChroma)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesFrost)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesInaros)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesMesa)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesMirage)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesNekros)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesNezha)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesNidus)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesOberon)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesRhino)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesTrinity)
        Me.CustomTabControl_abilitys.Controls.Add(Me.TabPage_abilitiesValkyr)
        Me.CustomTabControl_abilitys.Enabled = False
        Me.CustomTabControl_abilitys.Location = New System.Drawing.Point(486, 44)
        Me.CustomTabControl_abilitys.Name = "CustomTabControl_abilitys"
        Me.CustomTabControl_abilitys.SelectedIndex = 0
        Me.CustomTabControl_abilitys.Size = New System.Drawing.Size(281, 105)
        Me.CustomTabControl_abilitys.TabIndex = 59
        '
        'TabPage_abilitiesDefault
        '
        Me.TabPage_abilitiesDefault.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesDefault.Controls.Add(Me.Label_abilityPlaceholder)
        Me.TabPage_abilitiesDefault.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesDefault.Name = "TabPage_abilitiesDefault"
        Me.TabPage_abilitiesDefault.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesDefault.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesDefault.TabIndex = 1
        Me.TabPage_abilitiesDefault.Text = "Default"
        '
        'Label_abilityPlaceholder
        '
        Me.Label_abilityPlaceholder.AutoSize = True
        Me.Label_abilityPlaceholder.Location = New System.Drawing.Point(65, 30)
        Me.Label_abilityPlaceholder.Name = "Label_abilityPlaceholder"
        Me.Label_abilityPlaceholder.Size = New System.Drawing.Size(152, 34)
        Me.Label_abilityPlaceholder.TabIndex = 0
        Me.Label_abilityPlaceholder.Text = "This Warframe has no " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EHP affecting Abilities"
        Me.Label_abilityPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage_abilitiesChroma
        '
        Me.TabPage_abilitiesChroma.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesChroma.Controls.Add(Me.CheckBox_vexArmor)
        Me.TabPage_abilitiesChroma.Controls.Add(Me.CheckBox_elementalWard)
        Me.TabPage_abilitiesChroma.Controls.Add(Me.RadioButton_electricChroma)
        Me.TabPage_abilitiesChroma.Controls.Add(Me.RadioButton_iceChroma)
        Me.TabPage_abilitiesChroma.Controls.Add(Me.RadioButton_fireChroma)
        Me.TabPage_abilitiesChroma.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesChroma.Name = "TabPage_abilitiesChroma"
        Me.TabPage_abilitiesChroma.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesChroma.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesChroma.TabIndex = 0
        Me.TabPage_abilitiesChroma.Text = "Chroma"
        '
        'CheckBox_vexArmor
        '
        Me.CheckBox_vexArmor.AutoSize = True
        Me.CheckBox_vexArmor.Location = New System.Drawing.Point(151, 43)
        Me.CheckBox_vexArmor.Name = "CheckBox_vexArmor"
        Me.CheckBox_vexArmor.Size = New System.Drawing.Size(92, 21)
        Me.CheckBox_vexArmor.TabIndex = 18
        Me.CheckBox_vexArmor.Text = "Vex Armor"
        Me.CheckBox_vexArmor.UseVisualStyleBackColor = True
        '
        'CheckBox_elementalWard
        '
        Me.CheckBox_elementalWard.AutoSize = True
        Me.CheckBox_elementalWard.Location = New System.Drawing.Point(151, 17)
        Me.CheckBox_elementalWard.Name = "CheckBox_elementalWard"
        Me.CheckBox_elementalWard.Size = New System.Drawing.Size(127, 21)
        Me.CheckBox_elementalWard.TabIndex = 17
        Me.CheckBox_elementalWard.Text = "Elemental Ward"
        Me.CheckBox_elementalWard.UseVisualStyleBackColor = True
        '
        'RadioButton_electricChroma
        '
        Me.RadioButton_electricChroma.AutoSize = True
        Me.RadioButton_electricChroma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_electricChroma.Location = New System.Drawing.Point(9, 16)
        Me.RadioButton_electricChroma.Name = "RadioButton_electricChroma"
        Me.RadioButton_electricChroma.Size = New System.Drawing.Size(125, 21)
        Me.RadioButton_electricChroma.TabIndex = 16
        Me.RadioButton_electricChroma.Text = "Electric Chroma"
        Me.RadioButton_electricChroma.UseVisualStyleBackColor = True
        '
        'RadioButton_iceChroma
        '
        Me.RadioButton_iceChroma.AutoSize = True
        Me.RadioButton_iceChroma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_iceChroma.Location = New System.Drawing.Point(9, 68)
        Me.RadioButton_iceChroma.Name = "RadioButton_iceChroma"
        Me.RadioButton_iceChroma.Size = New System.Drawing.Size(97, 21)
        Me.RadioButton_iceChroma.TabIndex = 15
        Me.RadioButton_iceChroma.Text = "Ice Chroma"
        Me.RadioButton_iceChroma.UseVisualStyleBackColor = True
        '
        'RadioButton_fireChroma
        '
        Me.RadioButton_fireChroma.AutoSize = True
        Me.RadioButton_fireChroma.Checked = True
        Me.RadioButton_fireChroma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RadioButton_fireChroma.Location = New System.Drawing.Point(9, 42)
        Me.RadioButton_fireChroma.Name = "RadioButton_fireChroma"
        Me.RadioButton_fireChroma.Size = New System.Drawing.Size(103, 21)
        Me.RadioButton_fireChroma.TabIndex = 14
        Me.RadioButton_fireChroma.TabStop = True
        Me.RadioButton_fireChroma.Text = "Fire Chroma"
        Me.RadioButton_fireChroma.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesFrost
        '
        Me.TabPage_abilitiesFrost.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesFrost.Controls.Add(Me.NumericUpDown_icyAvalanche)
        Me.TabPage_abilitiesFrost.Controls.Add(Me.CheckBox_icyAvalanche)
        Me.TabPage_abilitiesFrost.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesFrost.Name = "TabPage_abilitiesFrost"
        Me.TabPage_abilitiesFrost.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesFrost.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesFrost.TabIndex = 2
        Me.TabPage_abilitiesFrost.Text = "Frost"
        '
        'NumericUpDown_icyAvalanche
        '
        Me.NumericUpDown_icyAvalanche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_icyAvalanche.Location = New System.Drawing.Point(203, 15)
        Me.NumericUpDown_icyAvalanche.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown_icyAvalanche.Name = "NumericUpDown_icyAvalanche"
        Me.NumericUpDown_icyAvalanche.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_icyAvalanche.TabIndex = 40
        '
        'CheckBox_icyAvalanche
        '
        Me.CheckBox_icyAvalanche.AutoSize = True
        Me.CheckBox_icyAvalanche.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_icyAvalanche.Name = "CheckBox_icyAvalanche"
        Me.CheckBox_icyAvalanche.Size = New System.Drawing.Size(114, 21)
        Me.CheckBox_icyAvalanche.TabIndex = 0
        Me.CheckBox_icyAvalanche.Text = "Icy Avalanche"
        Me.CheckBox_icyAvalanche.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesInaros
        '
        Me.TabPage_abilitiesInaros.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesInaros.Controls.Add(Me.NumericUpDown_scarabSwarm)
        Me.TabPage_abilitiesInaros.Controls.Add(Me.CheckBox_scarabSwarm)
        Me.TabPage_abilitiesInaros.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesInaros.Name = "TabPage_abilitiesInaros"
        Me.TabPage_abilitiesInaros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesInaros.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesInaros.TabIndex = 3
        Me.TabPage_abilitiesInaros.Text = "Inaros"
        '
        'NumericUpDown_scarabSwarm
        '
        Me.NumericUpDown_scarabSwarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_scarabSwarm.Location = New System.Drawing.Point(205, 15)
        Me.NumericUpDown_scarabSwarm.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown_scarabSwarm.Name = "NumericUpDown_scarabSwarm"
        Me.NumericUpDown_scarabSwarm.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_scarabSwarm.TabIndex = 39
        '
        'CheckBox_scarabSwarm
        '
        Me.CheckBox_scarabSwarm.AutoSize = True
        Me.CheckBox_scarabSwarm.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_scarabSwarm.Name = "CheckBox_scarabSwarm"
        Me.CheckBox_scarabSwarm.Size = New System.Drawing.Size(118, 21)
        Me.CheckBox_scarabSwarm.TabIndex = 1
        Me.CheckBox_scarabSwarm.Text = "Scarab Swarm"
        Me.CheckBox_scarabSwarm.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesMesa
        '
        Me.TabPage_abilitiesMesa.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesMesa.Controls.Add(Me.CheckBox_shatterShield)
        Me.TabPage_abilitiesMesa.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesMesa.Name = "TabPage_abilitiesMesa"
        Me.TabPage_abilitiesMesa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesMesa.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesMesa.TabIndex = 6
        Me.TabPage_abilitiesMesa.Text = "Mesa"
        '
        'CheckBox_shatterShield
        '
        Me.CheckBox_shatterShield.AutoSize = True
        Me.CheckBox_shatterShield.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_shatterShield.Name = "CheckBox_shatterShield"
        Me.CheckBox_shatterShield.Size = New System.Drawing.Size(116, 21)
        Me.CheckBox_shatterShield.TabIndex = 2
        Me.CheckBox_shatterShield.Text = "Shatter Shield"
        Me.CheckBox_shatterShield.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesMirage
        '
        Me.TabPage_abilitiesMirage.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesMirage.Controls.Add(Me.CheckBox_eclipse)
        Me.TabPage_abilitiesMirage.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesMirage.Name = "TabPage_abilitiesMirage"
        Me.TabPage_abilitiesMirage.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesMirage.TabIndex = 13
        Me.TabPage_abilitiesMirage.Text = "Mirage"
        '
        'CheckBox_eclipse
        '
        Me.CheckBox_eclipse.AutoSize = True
        Me.CheckBox_eclipse.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_eclipse.Name = "CheckBox_eclipse"
        Me.CheckBox_eclipse.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox_eclipse.TabIndex = 3
        Me.CheckBox_eclipse.Text = "Eclipse"
        Me.CheckBox_eclipse.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesNekros
        '
        Me.TabPage_abilitiesNekros.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesNekros.Controls.Add(Me.NumericUpDown_shieldOfShadows)
        Me.TabPage_abilitiesNekros.Controls.Add(Me.CheckBox_shieldOfShadows)
        Me.TabPage_abilitiesNekros.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesNekros.Name = "TabPage_abilitiesNekros"
        Me.TabPage_abilitiesNekros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesNekros.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesNekros.TabIndex = 11
        Me.TabPage_abilitiesNekros.Text = "Nekros"
        '
        'NumericUpDown_shieldOfShadows
        '
        Me.NumericUpDown_shieldOfShadows.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_shieldOfShadows.Location = New System.Drawing.Point(203, 15)
        Me.NumericUpDown_shieldOfShadows.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NumericUpDown_shieldOfShadows.Name = "NumericUpDown_shieldOfShadows"
        Me.NumericUpDown_shieldOfShadows.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_shieldOfShadows.TabIndex = 38
        '
        'CheckBox_shieldOfShadows
        '
        Me.CheckBox_shieldOfShadows.AutoSize = True
        Me.CheckBox_shieldOfShadows.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_shieldOfShadows.Name = "CheckBox_shieldOfShadows"
        Me.CheckBox_shieldOfShadows.Size = New System.Drawing.Size(147, 21)
        Me.CheckBox_shieldOfShadows.TabIndex = 3
        Me.CheckBox_shieldOfShadows.Text = "Shield of Shadows:"
        Me.CheckBox_shieldOfShadows.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesNezha
        '
        Me.TabPage_abilitiesNezha.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesNezha.Controls.Add(Me.Label_wardingHalo)
        Me.TabPage_abilitiesNezha.Controls.Add(Me.NumericUpDown_wardingHalo)
        Me.TabPage_abilitiesNezha.Controls.Add(Me.CheckBox_wardingHalo)
        Me.TabPage_abilitiesNezha.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesNezha.Name = "TabPage_abilitiesNezha"
        Me.TabPage_abilitiesNezha.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesNezha.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesNezha.TabIndex = 4
        Me.TabPage_abilitiesNezha.Text = "Nezha"
        '
        'Label_wardingHalo
        '
        Me.Label_wardingHalo.AutoSize = True
        Me.Label_wardingHalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_wardingHalo.Location = New System.Drawing.Point(6, 43)
        Me.Label_wardingHalo.Name = "Label_wardingHalo"
        Me.Label_wardingHalo.Size = New System.Drawing.Size(128, 17)
        Me.Label_wardingHalo.TabIndex = 64
        Me.Label_wardingHalo.Text = "Damage Received:"
        '
        'NumericUpDown_wardingHalo
        '
        Me.NumericUpDown_wardingHalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_wardingHalo.Location = New System.Drawing.Point(140, 41)
        Me.NumericUpDown_wardingHalo.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown_wardingHalo.Name = "NumericUpDown_wardingHalo"
        Me.NumericUpDown_wardingHalo.Size = New System.Drawing.Size(127, 23)
        Me.NumericUpDown_wardingHalo.TabIndex = 38
        '
        'CheckBox_wardingHalo
        '
        Me.CheckBox_wardingHalo.AutoSize = True
        Me.CheckBox_wardingHalo.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_wardingHalo.Name = "CheckBox_wardingHalo"
        Me.CheckBox_wardingHalo.Size = New System.Drawing.Size(113, 21)
        Me.CheckBox_wardingHalo.TabIndex = 2
        Me.CheckBox_wardingHalo.Text = "Warding Halo"
        Me.CheckBox_wardingHalo.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesNidus
        '
        Me.TabPage_abilitiesNidus.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesNidus.Controls.Add(Me.NumericUpDown_mutationStacks)
        Me.TabPage_abilitiesNidus.Controls.Add(Me.CheckBox_mutationStacks)
        Me.TabPage_abilitiesNidus.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesNidus.Name = "TabPage_abilitiesNidus"
        Me.TabPage_abilitiesNidus.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesNidus.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesNidus.TabIndex = 9
        Me.TabPage_abilitiesNidus.Text = "Nidus"
        '
        'NumericUpDown_mutationStacks
        '
        Me.NumericUpDown_mutationStacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_mutationStacks.Location = New System.Drawing.Point(203, 15)
        Me.NumericUpDown_mutationStacks.Name = "NumericUpDown_mutationStacks"
        Me.NumericUpDown_mutationStacks.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_mutationStacks.TabIndex = 37
        '
        'CheckBox_mutationStacks
        '
        Me.CheckBox_mutationStacks.AutoSize = True
        Me.CheckBox_mutationStacks.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_mutationStacks.Name = "CheckBox_mutationStacks"
        Me.CheckBox_mutationStacks.Size = New System.Drawing.Size(131, 21)
        Me.CheckBox_mutationStacks.TabIndex = 3
        Me.CheckBox_mutationStacks.Text = "Mutation Stacks:"
        Me.CheckBox_mutationStacks.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesOberon
        '
        Me.TabPage_abilitiesOberon.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesOberon.Controls.Add(Me.CheckBox_hallowedReckoning)
        Me.TabPage_abilitiesOberon.Controls.Add(Me.CheckBox_ironRenewal)
        Me.TabPage_abilitiesOberon.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesOberon.Name = "TabPage_abilitiesOberon"
        Me.TabPage_abilitiesOberon.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesOberon.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesOberon.TabIndex = 5
        Me.TabPage_abilitiesOberon.Text = "Oberon"
        '
        'CheckBox_hallowedReckoning
        '
        Me.CheckBox_hallowedReckoning.AutoSize = True
        Me.CheckBox_hallowedReckoning.Location = New System.Drawing.Point(9, 42)
        Me.CheckBox_hallowedReckoning.Name = "CheckBox_hallowedReckoning"
        Me.CheckBox_hallowedReckoning.Size = New System.Drawing.Size(155, 21)
        Me.CheckBox_hallowedReckoning.TabIndex = 4
        Me.CheckBox_hallowedReckoning.Text = "Hallowed Reckoning"
        Me.CheckBox_hallowedReckoning.UseVisualStyleBackColor = True
        '
        'CheckBox_ironRenewal
        '
        Me.CheckBox_ironRenewal.AutoSize = True
        Me.CheckBox_ironRenewal.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_ironRenewal.Name = "CheckBox_ironRenewal"
        Me.CheckBox_ironRenewal.Size = New System.Drawing.Size(109, 21)
        Me.CheckBox_ironRenewal.TabIndex = 3
        Me.CheckBox_ironRenewal.Text = "Iron Renewal"
        Me.CheckBox_ironRenewal.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesRhino
        '
        Me.TabPage_abilitiesRhino.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesRhino.Controls.Add(Me.NumericUpDown_ironcladCharge)
        Me.TabPage_abilitiesRhino.Controls.Add(Me.CheckBox_ironcladCharge)
        Me.TabPage_abilitiesRhino.Controls.Add(Me.CheckBox_ironSkin)
        Me.TabPage_abilitiesRhino.Controls.Add(Me.Label_ironSkin)
        Me.TabPage_abilitiesRhino.Controls.Add(Me.NumericUpDown_ironSkin)
        Me.TabPage_abilitiesRhino.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesRhino.Name = "TabPage_abilitiesRhino"
        Me.TabPage_abilitiesRhino.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesRhino.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesRhino.TabIndex = 7
        Me.TabPage_abilitiesRhino.Text = "Rhino"
        '
        'NumericUpDown_ironcladCharge
        '
        Me.NumericUpDown_ironcladCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_ironcladCharge.Location = New System.Drawing.Point(203, 67)
        Me.NumericUpDown_ironcladCharge.Name = "NumericUpDown_ironcladCharge"
        Me.NumericUpDown_ironcladCharge.Size = New System.Drawing.Size(61, 23)
        Me.NumericUpDown_ironcladCharge.TabIndex = 38
        '
        'CheckBox_ironcladCharge
        '
        Me.CheckBox_ironcladCharge.AutoSize = True
        Me.CheckBox_ironcladCharge.Location = New System.Drawing.Point(9, 68)
        Me.CheckBox_ironcladCharge.Name = "CheckBox_ironcladCharge"
        Me.CheckBox_ironcladCharge.Size = New System.Drawing.Size(127, 21)
        Me.CheckBox_ironcladCharge.TabIndex = 5
        Me.CheckBox_ironcladCharge.Text = "Ironclad Charge"
        Me.CheckBox_ironcladCharge.UseVisualStyleBackColor = True
        '
        'CheckBox_ironSkin
        '
        Me.CheckBox_ironSkin.AutoSize = True
        Me.CheckBox_ironSkin.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_ironSkin.Name = "CheckBox_ironSkin"
        Me.CheckBox_ironSkin.Size = New System.Drawing.Size(82, 21)
        Me.CheckBox_ironSkin.TabIndex = 4
        Me.CheckBox_ironSkin.Text = "Iron Skin"
        Me.CheckBox_ironSkin.UseVisualStyleBackColor = True
        '
        'Label_ironSkin
        '
        Me.Label_ironSkin.AutoSize = True
        Me.Label_ironSkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_ironSkin.Location = New System.Drawing.Point(6, 43)
        Me.Label_ironSkin.Name = "Label_ironSkin"
        Me.Label_ironSkin.Size = New System.Drawing.Size(128, 17)
        Me.Label_ironSkin.TabIndex = 66
        Me.Label_ironSkin.Text = "Damage Received:"
        '
        'NumericUpDown_ironSkin
        '
        Me.NumericUpDown_ironSkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_ironSkin.Location = New System.Drawing.Point(142, 41)
        Me.NumericUpDown_ironSkin.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown_ironSkin.Name = "NumericUpDown_ironSkin"
        Me.NumericUpDown_ironSkin.Size = New System.Drawing.Size(122, 23)
        Me.NumericUpDown_ironSkin.TabIndex = 65
        '
        'TabPage_abilitiesTrinity
        '
        Me.TabPage_abilitiesTrinity.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesTrinity.Controls.Add(Me.CheckBox_blessing)
        Me.TabPage_abilitiesTrinity.Controls.Add(Me.CheckBox_link)
        Me.TabPage_abilitiesTrinity.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesTrinity.Name = "TabPage_abilitiesTrinity"
        Me.TabPage_abilitiesTrinity.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesTrinity.TabIndex = 12
        Me.TabPage_abilitiesTrinity.Text = "Trinity"
        '
        'CheckBox_blessing
        '
        Me.CheckBox_blessing.AutoSize = True
        Me.CheckBox_blessing.Location = New System.Drawing.Point(9, 42)
        Me.CheckBox_blessing.Name = "CheckBox_blessing"
        Me.CheckBox_blessing.Size = New System.Drawing.Size(84, 21)
        Me.CheckBox_blessing.TabIndex = 41
        Me.CheckBox_blessing.Text = "Blessing:"
        Me.CheckBox_blessing.UseVisualStyleBackColor = True
        '
        'CheckBox_link
        '
        Me.CheckBox_link.AutoSize = True
        Me.CheckBox_link.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_link.Name = "CheckBox_link"
        Me.CheckBox_link.Size = New System.Drawing.Size(57, 21)
        Me.CheckBox_link.TabIndex = 39
        Me.CheckBox_link.Text = "Link:"
        Me.CheckBox_link.UseVisualStyleBackColor = True
        '
        'TabPage_abilitiesValkyr
        '
        Me.TabPage_abilitiesValkyr.BackColor = System.Drawing.Color.White
        Me.TabPage_abilitiesValkyr.Controls.Add(Me.CheckBox_warcry)
        Me.TabPage_abilitiesValkyr.Location = New System.Drawing.Point(1, 21)
        Me.TabPage_abilitiesValkyr.Name = "TabPage_abilitiesValkyr"
        Me.TabPage_abilitiesValkyr.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_abilitiesValkyr.Size = New System.Drawing.Size(279, 83)
        Me.TabPage_abilitiesValkyr.TabIndex = 8
        Me.TabPage_abilitiesValkyr.Text = "Valkyr"
        '
        'CheckBox_warcry
        '
        Me.CheckBox_warcry.AutoSize = True
        Me.CheckBox_warcry.Location = New System.Drawing.Point(9, 16)
        Me.CheckBox_warcry.Name = "CheckBox_warcry"
        Me.CheckBox_warcry.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox_warcry.TabIndex = 5
        Me.CheckBox_warcry.Text = "Warcry"
        Me.CheckBox_warcry.UseVisualStyleBackColor = True
        '
        'Panel_Ruler
        '
        Me.Panel_Ruler.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Ruler.Location = New System.Drawing.Point(470, 81)
        Me.Panel_Ruler.Name = "Panel_Ruler"
        Me.Panel_Ruler.Size = New System.Drawing.Size(20, 73)
        Me.Panel_Ruler.TabIndex = 110
        Me.Panel_Ruler.Visible = False
        '
        'GroupBox_focus
        '
        Me.GroupBox_focus.Controls.Add(Me.Label_focusPlaceholder)
        Me.GroupBox_focus.Enabled = False
        Me.GroupBox_focus.Location = New System.Drawing.Point(486, 156)
        Me.GroupBox_focus.Name = "GroupBox_focus"
        Me.GroupBox_focus.Size = New System.Drawing.Size(280, 170)
        Me.GroupBox_focus.TabIndex = 114
        Me.GroupBox_focus.TabStop = False
        Me.GroupBox_focus.Text = "  "
        '
        'Label_focusPlaceholder
        '
        Me.Label_focusPlaceholder.AutoSize = True
        Me.Label_focusPlaceholder.Location = New System.Drawing.Point(75, 66)
        Me.Label_focusPlaceholder.Name = "Label_focusPlaceholder"
        Me.Label_focusPlaceholder.Size = New System.Drawing.Size(132, 34)
        Me.Label_focusPlaceholder.TabIndex = 114
        Me.Label_focusPlaceholder.Text = "Focus will be added" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after the rework"
        Me.Label_focusPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_RulerTwo
        '
        Me.Panel_RulerTwo.BackColor = System.Drawing.Color.Transparent
        Me.Panel_RulerTwo.Location = New System.Drawing.Point(471, 451)
        Me.Panel_RulerTwo.Name = "Panel_RulerTwo"
        Me.Panel_RulerTwo.Size = New System.Drawing.Size(20, 21)
        Me.Panel_RulerTwo.TabIndex = 111
        Me.Panel_RulerTwo.Visible = False
        '
        'TabPage_companion
        '
        Me.TabPage_companion.Controls.Add(Me.GroupBox_companionResults)
        Me.TabPage_companion.Controls.Add(Me.NumericUpDown_companionStability)
        Me.TabPage_companion.Controls.Add(Me.Label_companionStability)
        Me.TabPage_companion.Controls.Add(Me.CheckBox_companionSurvivability)
        Me.TabPage_companion.Controls.Add(Me.GroupBox_companionSurvivability)
        Me.TabPage_companion.Controls.Add(Me.CheckBox_companionPrimeCollar)
        Me.TabPage_companion.Controls.Add(Me.ComboBox_companions)
        Me.TabPage_companion.ImageKey = "sentinel.png"
        Me.TabPage_companion.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_companion.Name = "TabPage_companion"
        Me.TabPage_companion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_companion.Size = New System.Drawing.Size(1018, 487)
        Me.TabPage_companion.TabIndex = 1
        Me.TabPage_companion.Text = "Companions "
        Me.TabPage_companion.UseVisualStyleBackColor = True
        '
        'GroupBox_companionResults
        '
        Me.GroupBox_companionResults.Controls.Add(Me.Label_companionEHP)
        Me.GroupBox_companionResults.Controls.Add(Me.TextBox_companionEHP)
        Me.GroupBox_companionResults.Controls.Add(Me.TextBox_companionArmor)
        Me.GroupBox_companionResults.Controls.Add(Me.Label_companionShield)
        Me.GroupBox_companionResults.Controls.Add(Me.TextBox_companionShield)
        Me.GroupBox_companionResults.Controls.Add(Me.Label_companionHealth)
        Me.GroupBox_companionResults.Controls.Add(Me.TextBox_companionHealth)
        Me.GroupBox_companionResults.Controls.Add(Me.Label_companionArmor)
        Me.GroupBox_companionResults.Location = New System.Drawing.Point(520, 172)
        Me.GroupBox_companionResults.Name = "GroupBox_companionResults"
        Me.GroupBox_companionResults.Size = New System.Drawing.Size(233, 147)
        Me.GroupBox_companionResults.TabIndex = 110
        Me.GroupBox_companionResults.TabStop = False
        '
        'Label_companionEHP
        '
        Me.Label_companionEHP.AutoSize = True
        Me.Label_companionEHP.Location = New System.Drawing.Point(9, 118)
        Me.Label_companionEHP.Name = "Label_companionEHP"
        Me.Label_companionEHP.Size = New System.Drawing.Size(111, 17)
        Me.Label_companionEHP.TabIndex = 111
        Me.Label_companionEHP.Text = "Effective Health:"
        '
        'TextBox_companionEHP
        '
        Me.TextBox_companionEHP.Location = New System.Drawing.Point(121, 115)
        Me.TextBox_companionEHP.Name = "TextBox_companionEHP"
        Me.TextBox_companionEHP.ReadOnly = True
        Me.TextBox_companionEHP.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_companionEHP.TabIndex = 110
        Me.TextBox_companionEHP.Text = "-"
        Me.TextBox_companionEHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_companionArmor
        '
        Me.TextBox_companionArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox_companionArmor.Location = New System.Drawing.Point(121, 25)
        Me.TextBox_companionArmor.Name = "TextBox_companionArmor"
        Me.TextBox_companionArmor.ReadOnly = True
        Me.TextBox_companionArmor.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_companionArmor.TabIndex = 105
        Me.TextBox_companionArmor.Text = "-"
        Me.TextBox_companionArmor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_companionShield
        '
        Me.Label_companionShield.AutoSize = True
        Me.Label_companionShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_companionShield.Location = New System.Drawing.Point(10, 77)
        Me.Label_companionShield.Name = "Label_companionShield"
        Me.Label_companionShield.Size = New System.Drawing.Size(51, 17)
        Me.Label_companionShield.TabIndex = 107
        Me.Label_companionShield.Text = "Shield:"
        '
        'TextBox_companionShield
        '
        Me.TextBox_companionShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox_companionShield.Location = New System.Drawing.Point(121, 77)
        Me.TextBox_companionShield.Name = "TextBox_companionShield"
        Me.TextBox_companionShield.ReadOnly = True
        Me.TextBox_companionShield.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_companionShield.TabIndex = 109
        Me.TextBox_companionShield.Text = "-"
        Me.TextBox_companionShield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_companionHealth
        '
        Me.Label_companionHealth.AutoSize = True
        Me.Label_companionHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_companionHealth.Location = New System.Drawing.Point(10, 51)
        Me.Label_companionHealth.Name = "Label_companionHealth"
        Me.Label_companionHealth.Size = New System.Drawing.Size(53, 17)
        Me.Label_companionHealth.TabIndex = 106
        Me.Label_companionHealth.Text = "Health:"
        '
        'TextBox_companionHealth
        '
        Me.TextBox_companionHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox_companionHealth.Location = New System.Drawing.Point(121, 51)
        Me.TextBox_companionHealth.Name = "TextBox_companionHealth"
        Me.TextBox_companionHealth.ReadOnly = True
        Me.TextBox_companionHealth.Size = New System.Drawing.Size(102, 23)
        Me.TextBox_companionHealth.TabIndex = 108
        Me.TextBox_companionHealth.Text = "-"
        Me.TextBox_companionHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_companionArmor
        '
        Me.Label_companionArmor.AutoSize = True
        Me.Label_companionArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_companionArmor.Location = New System.Drawing.Point(10, 25)
        Me.Label_companionArmor.Name = "Label_companionArmor"
        Me.Label_companionArmor.Size = New System.Drawing.Size(50, 17)
        Me.Label_companionArmor.TabIndex = 104
        Me.Label_companionArmor.Text = "Armor:"
        '
        'NumericUpDown_companionStability
        '
        Me.NumericUpDown_companionStability.Enabled = False
        Me.NumericUpDown_companionStability.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_companionStability.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_companionStability.Location = New System.Drawing.Point(430, 288)
        Me.NumericUpDown_companionStability.Minimum = New Decimal(New Integer() {95, 0, 0, -2147483648})
        Me.NumericUpDown_companionStability.Name = "NumericUpDown_companionStability"
        Me.NumericUpDown_companionStability.Size = New System.Drawing.Size(74, 23)
        Me.NumericUpDown_companionStability.TabIndex = 103
        Me.NumericUpDown_companionStability.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label_companionStability
        '
        Me.Label_companionStability.AutoSize = True
        Me.Label_companionStability.Enabled = False
        Me.Label_companionStability.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label_companionStability.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_companionStability.Location = New System.Drawing.Point(290, 290)
        Me.Label_companionStability.Name = "Label_companionStability"
        Me.Label_companionStability.Size = New System.Drawing.Size(114, 17)
        Me.Label_companionStability.TabIndex = 102
        Me.Label_companionStability.Text = "Genetic Stability:"
        '
        'CheckBox_companionSurvivability
        '
        Me.CheckBox_companionSurvivability.AutoSize = True
        Me.CheckBox_companionSurvivability.Enabled = False
        Me.CheckBox_companionSurvivability.Location = New System.Drawing.Point(293, 172)
        Me.CheckBox_companionSurvivability.Name = "CheckBox_companionSurvivability"
        Me.CheckBox_companionSurvivability.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox_companionSurvivability.TabIndex = 100
        Me.CheckBox_companionSurvivability.Tag = "GroupBox_companionSurvivability"
        Me.CheckBox_companionSurvivability.Text = "Survivability"
        Me.CheckBox_companionSurvivability.UseVisualStyleBackColor = True
        '
        'GroupBox_companionSurvivability
        '
        Me.GroupBox_companionSurvivability.Controls.Add(Me.CheckBox_companionLinkShield)
        Me.GroupBox_companionSurvivability.Controls.Add(Me.NumericUpDown_companionLinkShield)
        Me.GroupBox_companionSurvivability.Controls.Add(Me.CheckBox_companionLinkHealth)
        Me.GroupBox_companionSurvivability.Controls.Add(Me.NumericUpDown_companionLinkHealth)
        Me.GroupBox_companionSurvivability.Controls.Add(Me.CheckBox_companionLinkArmor)
        Me.GroupBox_companionSurvivability.Controls.Add(Me.NumericUpDown_companionLinkArmor)
        Me.GroupBox_companionSurvivability.Enabled = False
        Me.GroupBox_companionSurvivability.Location = New System.Drawing.Point(281, 172)
        Me.GroupBox_companionSurvivability.Name = "GroupBox_companionSurvivability"
        Me.GroupBox_companionSurvivability.Size = New System.Drawing.Size(233, 112)
        Me.GroupBox_companionSurvivability.TabIndex = 101
        Me.GroupBox_companionSurvivability.TabStop = False
        Me.GroupBox_companionSurvivability.Text = "  "
        '
        'CheckBox_companionLinkShield
        '
        Me.CheckBox_companionLinkShield.AutoSize = True
        Me.CheckBox_companionLinkShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_companionLinkShield.Location = New System.Drawing.Point(12, 79)
        Me.CheckBox_companionLinkShield.Name = "CheckBox_companionLinkShield"
        Me.CheckBox_companionLinkShield.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox_companionLinkShield.TabIndex = 22
        Me.CheckBox_companionLinkShield.Text = "Shield Link:"
        Me.CheckBox_companionLinkShield.UseVisualStyleBackColor = True
        '
        'NumericUpDown_companionLinkShield
        '
        Me.NumericUpDown_companionLinkShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_companionLinkShield.Location = New System.Drawing.Point(149, 78)
        Me.NumericUpDown_companionLinkShield.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_companionLinkShield.Name = "NumericUpDown_companionLinkShield"
        Me.NumericUpDown_companionLinkShield.Size = New System.Drawing.Size(74, 23)
        Me.NumericUpDown_companionLinkShield.TabIndex = 21
        '
        'CheckBox_companionLinkHealth
        '
        Me.CheckBox_companionLinkHealth.AutoSize = True
        Me.CheckBox_companionLinkHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_companionLinkHealth.Location = New System.Drawing.Point(12, 53)
        Me.CheckBox_companionLinkHealth.Name = "CheckBox_companionLinkHealth"
        Me.CheckBox_companionLinkHealth.Size = New System.Drawing.Size(102, 21)
        Me.CheckBox_companionLinkHealth.TabIndex = 20
        Me.CheckBox_companionLinkHealth.Text = "Health Link:"
        Me.CheckBox_companionLinkHealth.UseVisualStyleBackColor = True
        '
        'NumericUpDown_companionLinkHealth
        '
        Me.NumericUpDown_companionLinkHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_companionLinkHealth.Location = New System.Drawing.Point(149, 52)
        Me.NumericUpDown_companionLinkHealth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_companionLinkHealth.Name = "NumericUpDown_companionLinkHealth"
        Me.NumericUpDown_companionLinkHealth.Size = New System.Drawing.Size(74, 23)
        Me.NumericUpDown_companionLinkHealth.TabIndex = 19
        '
        'CheckBox_companionLinkArmor
        '
        Me.CheckBox_companionLinkArmor.AutoSize = True
        Me.CheckBox_companionLinkArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox_companionLinkArmor.Location = New System.Drawing.Point(12, 27)
        Me.CheckBox_companionLinkArmor.Name = "CheckBox_companionLinkArmor"
        Me.CheckBox_companionLinkArmor.Size = New System.Drawing.Size(99, 21)
        Me.CheckBox_companionLinkArmor.TabIndex = 18
        Me.CheckBox_companionLinkArmor.Text = "Armor Link:"
        Me.CheckBox_companionLinkArmor.UseVisualStyleBackColor = True
        '
        'NumericUpDown_companionLinkArmor
        '
        Me.NumericUpDown_companionLinkArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown_companionLinkArmor.Location = New System.Drawing.Point(149, 26)
        Me.NumericUpDown_companionLinkArmor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_companionLinkArmor.Name = "NumericUpDown_companionLinkArmor"
        Me.NumericUpDown_companionLinkArmor.Size = New System.Drawing.Size(74, 23)
        Me.NumericUpDown_companionLinkArmor.TabIndex = 17
        '
        'CheckBox_companionPrimeCollar
        '
        Me.CheckBox_companionPrimeCollar.AutoSize = True
        Me.CheckBox_companionPrimeCollar.Enabled = False
        Me.CheckBox_companionPrimeCollar.Location = New System.Drawing.Point(532, 145)
        Me.CheckBox_companionPrimeCollar.Name = "CheckBox_companionPrimeCollar"
        Me.CheckBox_companionPrimeCollar.Size = New System.Drawing.Size(103, 21)
        Me.CheckBox_companionPrimeCollar.TabIndex = 5
        Me.CheckBox_companionPrimeCollar.Text = "Prime Collar"
        Me.CheckBox_companionPrimeCollar.UseVisualStyleBackColor = True
        '
        'ComboBox_companions
        '
        Me.ComboBox_companions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_companions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBox_companions.FormattingEnabled = True
        Me.ComboBox_companions.Items.AddRange(New Object() {"Select a Pet", "Adarza", "Smeeta", "Chesa", "Huras", "Raksa", "Sahasa", "Sunika", "Helminth Charger"})
        Me.ComboBox_companions.Location = New System.Drawing.Point(280, 142)
        Me.ComboBox_companions.Name = "ComboBox_companions"
        Me.ComboBox_companions.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox_companions.TabIndex = 4
        '
        'TabPage_development
        '
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraPower)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraBasePower)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primePower)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeBasePower)
        Me.TabPage_development.Controls.Add(Me.ComboBox_power)
        Me.TabPage_development.Controls.Add(Me.ComboBox_basePower)
        Me.TabPage_development.Controls.Add(Me.Label_devUmbraStats)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraEnergy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraArmor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraBaseEnergy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraBaseShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraBaseHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbraBaseArmor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_umbras)
        Me.TabPage_development.Controls.Add(Me.CheckBox1)
        Me.TabPage_development.Controls.Add(Me.GroupBox1)
        Me.TabPage_development.Controls.Add(Me.Label_companions)
        Me.TabPage_development.Controls.Add(Me.Label_devPrimeStats)
        Me.TabPage_development.Controls.Add(Me.Label_devStats)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeEnergy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeArmor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeBaseEnergy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeBaseShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeBaseHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primeBaseArmor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_primes)
        Me.TabPage_development.Controls.Add(Me.ComboBox_petShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_petHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_petArmor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_energy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_shield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_health)
        Me.TabPage_development.Controls.Add(Me.ComboBox_armor)
        Me.TabPage_development.Controls.Add(Me.ComboBox_baseEnergy)
        Me.TabPage_development.Controls.Add(Me.ComboBox_baseShield)
        Me.TabPage_development.Controls.Add(Me.ComboBox_baseHealth)
        Me.TabPage_development.Controls.Add(Me.ComboBox_baseArmor)
        Me.TabPage_development.ImageKey = "alert.png"
        Me.TabPage_development.Location = New System.Drawing.Point(4, 29)
        Me.TabPage_development.Name = "TabPage_development"
        Me.TabPage_development.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_development.Size = New System.Drawing.Size(1018, 487)
        Me.TabPage_development.TabIndex = 2
        Me.TabPage_development.Text = "Development "
        Me.TabPage_development.UseVisualStyleBackColor = True
        '
        'ComboBox_umbraPower
        '
        Me.ComboBox_umbraPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraPower.FormattingEnabled = True
        Me.ComboBox_umbraPower.Items.AddRange(New Object() {"UMBRA POWER", "100_Excalibur"})
        Me.ComboBox_umbraPower.Location = New System.Drawing.Point(455, 391)
        Me.ComboBox_umbraPower.Name = "ComboBox_umbraPower"
        Me.ComboBox_umbraPower.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraPower.TabIndex = 115
        Me.ComboBox_umbraPower.TabStop = False
        '
        'ComboBox_umbraBasePower
        '
        Me.ComboBox_umbraBasePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraBasePower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraBasePower.FormattingEnabled = True
        Me.ComboBox_umbraBasePower.Items.AddRange(New Object() {"UMBRA BASE POWER", "100_Excalibur"})
        Me.ComboBox_umbraBasePower.Location = New System.Drawing.Point(329, 391)
        Me.ComboBox_umbraBasePower.Name = "ComboBox_umbraBasePower"
        Me.ComboBox_umbraBasePower.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraBasePower.TabIndex = 114
        Me.ComboBox_umbraBasePower.TabStop = False
        '
        'ComboBox_primePower
        '
        Me.ComboBox_primePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primePower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primePower.FormattingEnabled = True
        Me.ComboBox_primePower.Items.AddRange(New Object() {"PRIME POWER", "100_Ash", "100_Banshee", "100_Ember", "100_Excalibur", "100_Frost", "100_Loki", "100_Mag", "100_Nekros", "100_Nova", "100_Nyx", "100_Oberon", "100_Rhino", "100_Saryn", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt"})
        Me.ComboBox_primePower.Location = New System.Drawing.Point(166, 391)
        Me.ComboBox_primePower.Name = "ComboBox_primePower"
        Me.ComboBox_primePower.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primePower.TabIndex = 113
        Me.ComboBox_primePower.TabStop = False
        '
        'ComboBox_primeBasePower
        '
        Me.ComboBox_primeBasePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeBasePower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeBasePower.FormattingEnabled = True
        Me.ComboBox_primeBasePower.Items.AddRange(New Object() {"PRIME BASE POWER", "100_Ash", "100_Banshee", "100_Ember", "100_Excalibur", "100_Frost", "100_Loki", "100_Mag", "100_Nekros", "100_Nova", "100_Nyx", "100_Oberon", "100_Rhino", "100_Saryn", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt"})
        Me.ComboBox_primeBasePower.Location = New System.Drawing.Point(40, 391)
        Me.ComboBox_primeBasePower.Name = "ComboBox_primeBasePower"
        Me.ComboBox_primeBasePower.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeBasePower.TabIndex = 112
        Me.ComboBox_primeBasePower.TabStop = False
        '
        'ComboBox_power
        '
        Me.ComboBox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_power.FormattingEnabled = True
        Me.ComboBox_power.Items.AddRange(New Object() {"POWER", "100_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "100_Frost", "100_Harrow", "100_Hydroid", "100_Inaros", "100_Ivara", "100_Limbo", "100_Loki", "100_Mag", "100_Mesa", "100_Mirage", "100_Nekros", "100_Nezha", "115_Nidus", "100_Nova", "100_Nyx", "100_Oberon", "100_Octavia", "100_Rhino", "100_Saryn", "100_Titania", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt", "100_Wukong", "100_Zephyr"})
        Me.ComboBox_power.Location = New System.Drawing.Point(166, 180)
        Me.ComboBox_power.Name = "ComboBox_power"
        Me.ComboBox_power.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_power.TabIndex = 111
        Me.ComboBox_power.TabStop = False
        '
        'ComboBox_basePower
        '
        Me.ComboBox_basePower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_basePower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_basePower.FormattingEnabled = True
        Me.ComboBox_basePower.Items.AddRange(New Object() {"BASE POWER", "100_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "100_Frost", "100_Harrow", "100_Hydroid", "100_Inaros", "100_Ivara", "100_Limbo", "100_Loki", "100_Mag", "100_Mesa", "100_Mirage", "100_Nekros", "100_Nezha", "100_Nidus", "100_Nova", "100_Nyx", "100_Oberon", "100_Octavia", "100_Rhino", "100_Saryn", "100_Titania", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt", "100_Wukong", "100_Zephyr"})
        Me.ComboBox_basePower.Location = New System.Drawing.Point(40, 180)
        Me.ComboBox_basePower.Name = "ComboBox_basePower"
        Me.ComboBox_basePower.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_basePower.TabIndex = 110
        Me.ComboBox_basePower.TabStop = False
        '
        'Label_devUmbraStats
        '
        Me.Label_devUmbraStats.AutoSize = True
        Me.Label_devUmbraStats.Location = New System.Drawing.Point(326, 221)
        Me.Label_devUmbraStats.Name = "Label_devUmbraStats"
        Me.Label_devUmbraStats.Size = New System.Drawing.Size(144, 17)
        Me.Label_devUmbraStats.TabIndex = 109
        Me.Label_devUmbraStats.Text = "umbra warframe stats"
        '
        'ComboBox_umbraEnergy
        '
        Me.ComboBox_umbraEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraEnergy.FormattingEnabled = True
        Me.ComboBox_umbraEnergy.Items.AddRange(New Object() {"UMBRA ENERGY", "0_Excalibur"})
        Me.ComboBox_umbraEnergy.Location = New System.Drawing.Point(455, 361)
        Me.ComboBox_umbraEnergy.Name = "ComboBox_umbraEnergy"
        Me.ComboBox_umbraEnergy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraEnergy.TabIndex = 108
        Me.ComboBox_umbraEnergy.TabStop = False
        '
        'ComboBox_umbraShield
        '
        Me.ComboBox_umbraShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraShield.FormattingEnabled = True
        Me.ComboBox_umbraShield.Items.AddRange(New Object() {"UMBRA SHIELD", "0_Excalibur"})
        Me.ComboBox_umbraShield.Location = New System.Drawing.Point(455, 331)
        Me.ComboBox_umbraShield.Name = "ComboBox_umbraShield"
        Me.ComboBox_umbraShield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraShield.TabIndex = 107
        Me.ComboBox_umbraShield.TabStop = False
        '
        'ComboBox_umbraHealth
        '
        Me.ComboBox_umbraHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraHealth.FormattingEnabled = True
        Me.ComboBox_umbraHealth.Items.AddRange(New Object() {"UMBRA HEALTH", "0_Excalibur"})
        Me.ComboBox_umbraHealth.Location = New System.Drawing.Point(455, 301)
        Me.ComboBox_umbraHealth.Name = "ComboBox_umbraHealth"
        Me.ComboBox_umbraHealth.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraHealth.TabIndex = 106
        Me.ComboBox_umbraHealth.TabStop = False
        '
        'ComboBox_umbraArmor
        '
        Me.ComboBox_umbraArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraArmor.FormattingEnabled = True
        Me.ComboBox_umbraArmor.Items.AddRange(New Object() {"UMBRA ARMOR", "0_Excalibur"})
        Me.ComboBox_umbraArmor.Location = New System.Drawing.Point(455, 271)
        Me.ComboBox_umbraArmor.Name = "ComboBox_umbraArmor"
        Me.ComboBox_umbraArmor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraArmor.TabIndex = 105
        Me.ComboBox_umbraArmor.TabStop = False
        '
        'ComboBox_umbraBaseEnergy
        '
        Me.ComboBox_umbraBaseEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraBaseEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraBaseEnergy.FormattingEnabled = True
        Me.ComboBox_umbraBaseEnergy.Items.AddRange(New Object() {"UMBRA BASE ENERGY", "0_Excalibur"})
        Me.ComboBox_umbraBaseEnergy.Location = New System.Drawing.Point(329, 361)
        Me.ComboBox_umbraBaseEnergy.Name = "ComboBox_umbraBaseEnergy"
        Me.ComboBox_umbraBaseEnergy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraBaseEnergy.TabIndex = 104
        Me.ComboBox_umbraBaseEnergy.TabStop = False
        '
        'ComboBox_umbraBaseShield
        '
        Me.ComboBox_umbraBaseShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraBaseShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraBaseShield.FormattingEnabled = True
        Me.ComboBox_umbraBaseShield.Items.AddRange(New Object() {"UMBRA BASE SHIELD", "0_Excalibur"})
        Me.ComboBox_umbraBaseShield.Location = New System.Drawing.Point(329, 331)
        Me.ComboBox_umbraBaseShield.Name = "ComboBox_umbraBaseShield"
        Me.ComboBox_umbraBaseShield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraBaseShield.TabIndex = 103
        Me.ComboBox_umbraBaseShield.TabStop = False
        '
        'ComboBox_umbraBaseHealth
        '
        Me.ComboBox_umbraBaseHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraBaseHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraBaseHealth.FormattingEnabled = True
        Me.ComboBox_umbraBaseHealth.Items.AddRange(New Object() {"UMBRA BASE HEALTH", "0_Excalibur"})
        Me.ComboBox_umbraBaseHealth.Location = New System.Drawing.Point(329, 301)
        Me.ComboBox_umbraBaseHealth.Name = "ComboBox_umbraBaseHealth"
        Me.ComboBox_umbraBaseHealth.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraBaseHealth.TabIndex = 102
        Me.ComboBox_umbraBaseHealth.TabStop = False
        '
        'ComboBox_umbraBaseArmor
        '
        Me.ComboBox_umbraBaseArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbraBaseArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbraBaseArmor.FormattingEnabled = True
        Me.ComboBox_umbraBaseArmor.Items.AddRange(New Object() {"UMBRA BASE ARMOR", "0_Excalibur"})
        Me.ComboBox_umbraBaseArmor.Location = New System.Drawing.Point(329, 271)
        Me.ComboBox_umbraBaseArmor.Name = "ComboBox_umbraBaseArmor"
        Me.ComboBox_umbraBaseArmor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_umbraBaseArmor.TabIndex = 101
        Me.ComboBox_umbraBaseArmor.TabStop = False
        '
        'ComboBox_umbras
        '
        Me.ComboBox_umbras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_umbras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_umbras.FormattingEnabled = True
        Me.ComboBox_umbras.Items.AddRange(New Object() {"UMBRAS", "Excalibur"})
        Me.ComboBox_umbras.Location = New System.Drawing.Point(329, 241)
        Me.ComboBox_umbras.Name = "ComboBox_umbras"
        Me.ComboBox_umbras.Size = New System.Drawing.Size(246, 24)
        Me.ComboBox_umbras.TabIndex = 100
        Me.ComboBox_umbras.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(778, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 21)
        Me.CheckBox1.TabIndex = 98
        Me.CheckBox1.Text = "NAME"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(766, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 159)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  "
        '
        'Label_companions
        '
        Me.Label_companions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_companions.AutoSize = True
        Me.Label_companions.Location = New System.Drawing.Point(326, 40)
        Me.Label_companions.Name = "Label_companions"
        Me.Label_companions.Size = New System.Drawing.Size(62, 17)
        Me.Label_companions.TabIndex = 97
        Me.Label_companions.Text = "pet stats"
        '
        'Label_devPrimeStats
        '
        Me.Label_devPrimeStats.AutoSize = True
        Me.Label_devPrimeStats.Location = New System.Drawing.Point(37, 221)
        Me.Label_devPrimeStats.Name = "Label_devPrimeStats"
        Me.Label_devPrimeStats.Size = New System.Drawing.Size(139, 17)
        Me.Label_devPrimeStats.TabIndex = 96
        Me.Label_devPrimeStats.Text = "prime warframe stats"
        '
        'Label_devStats
        '
        Me.Label_devStats.AutoSize = True
        Me.Label_devStats.Location = New System.Drawing.Point(37, 40)
        Me.Label_devStats.Name = "Label_devStats"
        Me.Label_devStats.Size = New System.Drawing.Size(100, 17)
        Me.Label_devStats.TabIndex = 95
        Me.Label_devStats.Text = "warframe stats"
        '
        'ComboBox_primeEnergy
        '
        Me.ComboBox_primeEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeEnergy.FormattingEnabled = True
        Me.ComboBox_primeEnergy.Items.AddRange(New Object() {"PRIME ENERGY", "150_Ash", "262.5_Banshee", "225_Ember", "150_Excalibur", "150_Frost", "262.5_Loki", "150_Mag", "187.5_Nekros", "262.5_Nova", "225_Nyx", "262.5_Oberon", "150_Rhino", "300_Saryn", "225_Trinity", "225_Valkyr", "225_Vauban", "300_Volt"})
        Me.ComboBox_primeEnergy.Location = New System.Drawing.Point(166, 361)
        Me.ComboBox_primeEnergy.Name = "ComboBox_primeEnergy"
        Me.ComboBox_primeEnergy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeEnergy.TabIndex = 94
        Me.ComboBox_primeEnergy.TabStop = False
        '
        'ComboBox_primeShield
        '
        Me.ComboBox_primeShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeShield.FormattingEnabled = True
        Me.ComboBox_primeShield.Items.AddRange(New Object() {"PRIME SHIELD", "375_Ash", "300_Banshee", "375_Ember", "300_Excalibur", "525_Frost", "225_Loki", "450_Mag", "450_Nekros", "300_Nova", "375_Nyx", "300_Oberon", "450_Rhino", "300_Saryn", "450_Trinity", "150_Valkyr", "300_Vauban", "450_Volt"})
        Me.ComboBox_primeShield.Location = New System.Drawing.Point(166, 331)
        Me.ComboBox_primeShield.Name = "ComboBox_primeShield"
        Me.ComboBox_primeShield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeShield.TabIndex = 93
        Me.ComboBox_primeShield.TabStop = False
        '
        'ComboBox_primeHealth
        '
        Me.ComboBox_primeHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeHealth.FormattingEnabled = True
        Me.ComboBox_primeHealth.Items.AddRange(New Object() {"PRIME HEALTH", "450_Ash", "300_Banshee", "300_Ember", "300_Excalibur", "300_Frost", "225_Loki", "300_Mag", "300_Nekros", "300_Nova", "300_Nyx", "375_Oberon", "300_Rhino", "375_Saryn", "300_Trinity", "300_Valkyr", "300_Vauban", "300_Volt"})
        Me.ComboBox_primeHealth.Location = New System.Drawing.Point(166, 301)
        Me.ComboBox_primeHealth.Name = "ComboBox_primeHealth"
        Me.ComboBox_primeHealth.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeHealth.TabIndex = 92
        Me.ComboBox_primeHealth.TabStop = False
        '
        'ComboBox_primeArmor
        '
        Me.ComboBox_primeArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeArmor.FormattingEnabled = True
        Me.ComboBox_primeArmor.Items.AddRange(New Object() {"PRIME ARMOR", "150_Ash", "65_Banshee", "125_Ember", "250_Excalibur", "300_Frost", "65_Loki", "65_Mag", "65_Nekros", "65_Nova", "50_Nyx", "225_Oberon", "275_Rhino", "225_Saryn", "15_Trinity", "700_Valkyr", "100_Vauban", "100_Volt"})
        Me.ComboBox_primeArmor.Location = New System.Drawing.Point(166, 271)
        Me.ComboBox_primeArmor.Name = "ComboBox_primeArmor"
        Me.ComboBox_primeArmor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeArmor.TabIndex = 91
        Me.ComboBox_primeArmor.TabStop = False
        '
        'ComboBox_primeBaseEnergy
        '
        Me.ComboBox_primeBaseEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeBaseEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeBaseEnergy.FormattingEnabled = True
        Me.ComboBox_primeBaseEnergy.Items.AddRange(New Object() {"PRIME BASE ENERGY", "100_Ash", "175_Banshee", "150_Ember", "100_Excalibur", "100_Frost", "175_Loki", "100_Mag", "125_Nekros", "175_Nova", "150_Nyx", "175_Oberon", "100_Rhino", "200_Saryn", "150_Trinity", "150_Valkyr", "150_Vauban", "200_Volt"})
        Me.ComboBox_primeBaseEnergy.Location = New System.Drawing.Point(40, 361)
        Me.ComboBox_primeBaseEnergy.Name = "ComboBox_primeBaseEnergy"
        Me.ComboBox_primeBaseEnergy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeBaseEnergy.TabIndex = 90
        Me.ComboBox_primeBaseEnergy.TabStop = False
        '
        'ComboBox_primeBaseShield
        '
        Me.ComboBox_primeBaseShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeBaseShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeBaseShield.FormattingEnabled = True
        Me.ComboBox_primeBaseShield.Items.AddRange(New Object() {"PRIME BASE SHIELD", "125_Ash", "100_Banshee", "125_Ember", "100_Excalibur", "175_Frost", "75_Loki", "150_Mag", "150_Nekros", "100_Nova", "125_Nyx", "100_Oberon", "150_Rhino", "100_Saryn", "150_Trinity", "50_Valkyr", "100_Vauban", "150_Volt"})
        Me.ComboBox_primeBaseShield.Location = New System.Drawing.Point(40, 331)
        Me.ComboBox_primeBaseShield.Name = "ComboBox_primeBaseShield"
        Me.ComboBox_primeBaseShield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeBaseShield.TabIndex = 89
        Me.ComboBox_primeBaseShield.TabStop = False
        '
        'ComboBox_primeBaseHealth
        '
        Me.ComboBox_primeBaseHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeBaseHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeBaseHealth.FormattingEnabled = True
        Me.ComboBox_primeBaseHealth.Items.AddRange(New Object() {"PRIME BASE HEALTH", "150_Ash", "100_Banshee", "100_Ember", "100_Excalibur", "100_Frost", "75_Loki", "100_Mag", "100_Nekros", "100_Nova", "100_Nyx", "125_Oberon", "100_Rhino", "125_Saryn", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt"})
        Me.ComboBox_primeBaseHealth.Location = New System.Drawing.Point(40, 301)
        Me.ComboBox_primeBaseHealth.Name = "ComboBox_primeBaseHealth"
        Me.ComboBox_primeBaseHealth.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeBaseHealth.TabIndex = 88
        Me.ComboBox_primeBaseHealth.TabStop = False
        '
        'ComboBox_primeBaseArmor
        '
        Me.ComboBox_primeBaseArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primeBaseArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primeBaseArmor.FormattingEnabled = True
        Me.ComboBox_primeBaseArmor.Items.AddRange(New Object() {"PRIME BASE ARMOR", "150_Ash", "65_Banshee", "125_Ember", "250_Excalibur", "300_Frost", "65_Loki", "65_Mag", "65_Nekros", "65_Nova", "50_Nyx", "225_Oberon", "275_Rhino", "225_Saryn", "15_Trinity", "700_Valkyr", "100_Vauban", "100_Volt"})
        Me.ComboBox_primeBaseArmor.Location = New System.Drawing.Point(40, 271)
        Me.ComboBox_primeBaseArmor.Name = "ComboBox_primeBaseArmor"
        Me.ComboBox_primeBaseArmor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_primeBaseArmor.TabIndex = 87
        Me.ComboBox_primeBaseArmor.TabStop = False
        '
        'ComboBox_primes
        '
        Me.ComboBox_primes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_primes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_primes.FormattingEnabled = True
        Me.ComboBox_primes.Items.AddRange(New Object() {"PRIMES", "Ash", "Banshee", "Ember", "Excalibur", "Frost", "Loki", "Mag", "Nekros", "Nova", "Nyx", "Oberon", "Rhino", "Saryn", "Trinity", "Valkyr", "Vauban", "Volt"})
        Me.ComboBox_primes.Location = New System.Drawing.Point(40, 241)
        Me.ComboBox_primes.Name = "ComboBox_primes"
        Me.ComboBox_primes.Size = New System.Drawing.Size(246, 24)
        Me.ComboBox_primes.TabIndex = 75
        Me.ComboBox_primes.TabStop = False
        '
        'ComboBox_petShield
        '
        Me.ComboBox_petShield.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_petShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_petShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_petShield.FormattingEnabled = True
        Me.ComboBox_petShield.Items.AddRange(New Object() {"PET SHIELD", "210_Adarza", "180_Smeeta", "225_Chesa", "375_Huras", "300_Raksa", "225_Sahasa", "270_Sunika", "225_HelminthCharger"})
        Me.ComboBox_petShield.Location = New System.Drawing.Point(329, 120)
        Me.ComboBox_petShield.Name = "ComboBox_petShield"
        Me.ComboBox_petShield.Size = New System.Drawing.Size(248, 24)
        Me.ComboBox_petShield.TabIndex = 86
        Me.ComboBox_petShield.TabStop = False
        '
        'ComboBox_petHealth
        '
        Me.ComboBox_petHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_petHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_petHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_petHealth.FormattingEnabled = True
        Me.ComboBox_petHealth.Items.AddRange(New Object() {"PET HEALTH", "240_Adarza", "300_Smeeta", "375_Chesa", "75_Huras", "300_Raksa", "375_Sahasa", "330_Sunika", "285_HelminthCharger"})
        Me.ComboBox_petHealth.Location = New System.Drawing.Point(329, 90)
        Me.ComboBox_petHealth.Name = "ComboBox_petHealth"
        Me.ComboBox_petHealth.Size = New System.Drawing.Size(248, 24)
        Me.ComboBox_petHealth.TabIndex = 85
        Me.ComboBox_petHealth.TabStop = False
        '
        'ComboBox_petArmor
        '
        Me.ComboBox_petArmor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_petArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_petArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_petArmor.FormattingEnabled = True
        Me.ComboBox_petArmor.Items.AddRange(New Object() {"PET ARMOR", "40_Adarza", "50_Smeeta", "50_Chesa", "50_Huras", "50_Raksa", "50_Sahasa", "50_Sunika", "50_HelminthCharger"})
        Me.ComboBox_petArmor.Location = New System.Drawing.Point(329, 60)
        Me.ComboBox_petArmor.Name = "ComboBox_petArmor"
        Me.ComboBox_petArmor.Size = New System.Drawing.Size(248, 24)
        Me.ComboBox_petArmor.TabIndex = 84
        Me.ComboBox_petArmor.TabStop = False
        '
        'ComboBox_energy
        '
        Me.ComboBox_energy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_energy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_energy.FormattingEnabled = True
        Me.ComboBox_energy.Items.AddRange(New Object() {"ENERGY", "150_Ash", "225_Atlas", "225_Banshee", "225_Chroma", "225_Ember", "225_Equinox", "150_Excalibur", "150_Frost", "150_Harrow", "150_Hydroid", "150_Inaros", "262.5_Ivara", "225_Limbo", "225_Loki", "150_Mag", "150_Mesa", "225_Mirage", "150_Nekros", "225_Nezha", "150_Nidus", "225_Nova", "225_Nyx", "225_Oberon", "225_Octavia", "150_Rhino", "225_Saryn", "150_Titania", "225_Trinity", "150_Valkyr", "225_Vauban", "150_Volt", "150_Wukong", "150_Zephyr"})
        Me.ComboBox_energy.Location = New System.Drawing.Point(166, 150)
        Me.ComboBox_energy.Name = "ComboBox_energy"
        Me.ComboBox_energy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_energy.TabIndex = 83
        Me.ComboBox_energy.TabStop = False
        '
        'ComboBox_shield
        '
        Me.ComboBox_shield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_shield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_shield.FormattingEnabled = True
        Me.ComboBox_shield.Items.AddRange(New Object() {"SHIELD", "300_Ash", "300_Atlas", "300_Banshee", "300_Chroma", "300_Ember", "300_Equinox", "300_Excalibur", "450_Frost", "450_Harrow", "345_Hydroid", "0_Inaros", "300_Ivara", "225_Limbo", "225_Loki", "450_Mag", "225_Mesa", "240_Mirage", "270_Nekros", "225_Nezha", "0_Nidus", "225_Nova", "300_Nyx", "300_Oberon", "225_Octavia", "450_Rhino", "300_Saryn", "300_Titania", "300_Trinity", "150_Valkyr", "225_Vauban", "450_Volt", "375_Wukong", "450_Zephyr"})
        Me.ComboBox_shield.Location = New System.Drawing.Point(166, 120)
        Me.ComboBox_shield.Name = "ComboBox_shield"
        Me.ComboBox_shield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_shield.TabIndex = 82
        Me.ComboBox_shield.TabStop = False
        '
        'ComboBox_health
        '
        Me.ComboBox_health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_health.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_health.FormattingEnabled = True
        Me.ComboBox_health.Items.AddRange(New Object() {"HEALTH", "450_Ash", "300_Atlas", "300_Banshee", "300_Chroma", "300_Ember", "300_Equinox", "300_Excalibur", "300_Frost", "300_Harrow", "300_Hydroid", "2200_Inaros", "225_Ivara", "300_Limbo", "225_Loki", "255_Mag", "375_Mesa", "240_Mirage", "300_Nekros", "225_Nezha", "450_Nidus", "300_Nova", "300_Nyx", "375_Oberon", "300_Octavia", "300_Rhino", "375_Saryn", "300_Titania", "300_Trinity", "300_Valkyr", "300_Vauban", "300_Volt", "300_Wukong", "450_Zephyr"})
        Me.ComboBox_health.Location = New System.Drawing.Point(166, 90)
        Me.ComboBox_health.Name = "ComboBox_health"
        Me.ComboBox_health.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_health.TabIndex = 81
        Me.ComboBox_health.TabStop = False
        '
        'ComboBox_armor
        '
        Me.ComboBox_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_armor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_armor.FormattingEnabled = True
        Me.ComboBox_armor.Items.AddRange(New Object() {"ARMOR", "65_Ash", "450_Atlas", "15_Banshee", "350_Chroma", "100_Ember", "100_Equinox", "225_Excalibur", "300_Frost", "150_Harrow", "65_Hydroid", "200_Inaros", "65_Ivara", "65_Limbo", "65_Loki", "65_Mag", "65_Mesa", "65_Mirage", "65_Nekros", "175_Nezha", "450_Nidus", "65_Nova", "15_Nyx", "150_Oberon", "125_Octavia", "190_Rhino", "175_Saryn", "65_Titania", "15_Trinity", "600_Valkyr", "50_Vauban", "15_Volt", "225_Wukong", "15_Zephyr"})
        Me.ComboBox_armor.Location = New System.Drawing.Point(166, 60)
        Me.ComboBox_armor.Name = "ComboBox_armor"
        Me.ComboBox_armor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_armor.TabIndex = 80
        Me.ComboBox_armor.TabStop = False
        '
        'ComboBox_baseEnergy
        '
        Me.ComboBox_baseEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_baseEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_baseEnergy.FormattingEnabled = True
        Me.ComboBox_baseEnergy.Items.AddRange(New Object() {"BASE ENERGY", "100_Ash", "150_Atlas", "150_Banshee", "150_Chroma", "150_Ember", "150_Equinox", "100_Excalibur", "100_Frost", "100_Harrow", "100_Hydroid", "100_Inaros", "175_Ivara", "150_Limbo", "150_Loki", "100_Mag", "100_Mesa", "150_Mirage", "100_Nekros", "150_Nezha", "100_Nidus", "150_Nova", "150_Nyx", "150_Oberon", "150_Octavia", "100_Rhino", "150_Saryn", "100_Titania", "150_Trinity", "100_Valkyr", "150_Vauban", "100_Volt", "100_Wukong", "100_Zephyr"})
        Me.ComboBox_baseEnergy.Location = New System.Drawing.Point(40, 150)
        Me.ComboBox_baseEnergy.Name = "ComboBox_baseEnergy"
        Me.ComboBox_baseEnergy.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_baseEnergy.TabIndex = 79
        Me.ComboBox_baseEnergy.TabStop = False
        '
        'ComboBox_baseShield
        '
        Me.ComboBox_baseShield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_baseShield.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_baseShield.FormattingEnabled = True
        Me.ComboBox_baseShield.Items.AddRange(New Object() {"BASE SHIELD", "100_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "150_Frost", "150_Harrow", "115_Hydroid", "0_Inaros", "100_Ivara", "75_Limbo", "75_Loki", "150_Mag", "75_Mesa", "80_Mirage", "90_Nekros", "75_Nezha", "0_Nidus", "75_Nova", "100_Nyx", "100_Oberon", "75_Octavia", "150_Rhino", "100_Saryn", "100_Titania", "100_Trinity", "50_Valkyr", "75_Vauban", "150_Volt", "125_Wukong", "150_Zephyr"})
        Me.ComboBox_baseShield.Location = New System.Drawing.Point(40, 120)
        Me.ComboBox_baseShield.Name = "ComboBox_baseShield"
        Me.ComboBox_baseShield.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_baseShield.TabIndex = 78
        Me.ComboBox_baseShield.TabStop = False
        '
        'ComboBox_baseHealth
        '
        Me.ComboBox_baseHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_baseHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_baseHealth.FormattingEnabled = True
        Me.ComboBox_baseHealth.Items.AddRange(New Object() {"BASE HEALTH", "150_Ash", "100_Atlas", "100_Banshee", "100_Chroma", "100_Ember", "100_Equinox", "100_Excalibur", "100_Frost", "100_Harrow", "100_Hydroid", "550_Inaros", "75_Ivara", "100_Limbo", "75_Loki", "75_Mag", "125_Mesa", "80_Mirage", "100_Nekros", "75_Nezha", "150_Nidus", "100_Nova", "100_Nyx", "125_Oberon", "100_Octavia", "100_Rhino", "125_Saryn", "100_Titania", "100_Trinity", "100_Valkyr", "100_Vauban", "100_Volt", "100_Wukong", "150_Zephyr"})
        Me.ComboBox_baseHealth.Location = New System.Drawing.Point(40, 90)
        Me.ComboBox_baseHealth.Name = "ComboBox_baseHealth"
        Me.ComboBox_baseHealth.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_baseHealth.TabIndex = 77
        Me.ComboBox_baseHealth.TabStop = False
        '
        'ComboBox_baseArmor
        '
        Me.ComboBox_baseArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_baseArmor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_baseArmor.FormattingEnabled = True
        Me.ComboBox_baseArmor.Items.AddRange(New Object() {"BASE ARMOR", "65_Ash", "450_Atlas", "15_Banshee", "350_Chroma", "100_Ember", "100_Equinox", "225_Excalibur", "300_Frost", "150_Harrow", "65_Hydroid", "200_Inaros", "65_Ivara", "65_Limbo", "65_Loki", "65_Mag", "65_Mesa", "65_Mirage", "65_Nekros", "175_Nezha", "300_Nidus", "65_Nova", "15_Nyx", "150_Oberon", "125_Octavia", "190_Rhino", "175_Saryn", "65_Titania", "15_Trinity", "600_Valkyr", "50_Vauban", "15_Volt", "225_Wukong", "15_Zephyr"})
        Me.ComboBox_baseArmor.Location = New System.Drawing.Point(40, 60)
        Me.ComboBox_baseArmor.Name = "ComboBox_baseArmor"
        Me.ComboBox_baseArmor.Size = New System.Drawing.Size(120, 24)
        Me.ComboBox_baseArmor.TabIndex = 76
        Me.ComboBox_baseArmor.TabStop = False
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "warframe.png")
        Me.Icons.Images.SetKeyName(1, "sentinel.png")
        Me.Icons.Images.SetKeyName(2, "arcane.png")
        Me.Icons.Images.SetKeyName(3, "archwing.png")
        Me.Icons.Images.SetKeyName(4, "alert.png")
        '
        'Label_author
        '
        Me.Label_author.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_author.AutoSize = True
        Me.Label_author.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_author.Location = New System.Drawing.Point(865, 7)
        Me.Label_author.Name = "Label_author"
        Me.Label_author.Size = New System.Drawing.Size(155, 13)
        Me.Label_author.TabIndex = 1
        Me.Label_author.Text = "Made with     By /u/xEpicBradx"
        '
        'Label_love
        '
        Me.Label_love.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_love.AutoSize = True
        Me.Label_love.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label_love.ForeColor = System.Drawing.Color.Red
        Me.Label_love.Location = New System.Drawing.Point(917, 6)
        Me.Label_love.Name = "Label_love"
        Me.Label_love.Size = New System.Drawing.Size(15, 15)
        Me.Label_love.TabIndex = 2
        Me.Label_love.Text = "♥"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 520)
        Me.Controls.Add(Me.Label_love)
        Me.Controls.Add(Me.Label_author)
        Me.Controls.Add(Me.TabControl_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Warframe EHP Calculator"
        Me.TabControl_main.ResumeLayout(False)
        Me.TabPage_warframe.ResumeLayout(False)
        Me.TabPage_warframe.PerformLayout()
        Me.GroupBox_warframeResults.ResumeLayout(False)
        Me.GroupBox_warframeResults.PerformLayout()
        Me.CustomTabControl_arcaneHelmets.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsDefault.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsDefault.PerformLayout()
        Me.TabPage_arcaneHelmetsAsh.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsAsh.PerformLayout()
        Me.TabPage_arcaneHelmetsBanshee.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsBanshee.PerformLayout()
        Me.TabPage_arcaneHelmetsEmber.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsEmber.PerformLayout()
        Me.TabPage_arcaneHelmetsExcalibur.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsExcalibur.PerformLayout()
        Me.TabPage_arcaneHelmetsFrost.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsFrost.PerformLayout()
        Me.TabPage_arcaneHelmetsLoki.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsLoki.PerformLayout()
        Me.TabPage_arcaneHelmetsMag.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsMag.PerformLayout()
        Me.TabPage_arcaneHelmetsNova.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsNova.PerformLayout()
        Me.TabPage_arcaneHelmetsNyx.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsNyx.PerformLayout()
        Me.TabPage_arcaneHelmetsRhino.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsRhino.PerformLayout()
        Me.TabPage_arcaneHelmetsSaryn.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsSaryn.PerformLayout()
        Me.TabPage_arcaneHelmetsTrinity.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsTrinity.PerformLayout()
        Me.TabPage_arcaneHelmetsVauban.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsVauban.PerformLayout()
        Me.TabPage_arcaneHelmetsVolt.ResumeLayout(False)
        Me.TabPage_arcaneHelmetsVolt.PerformLayout()
        Me.GroupBox_oversheilds.ResumeLayout(False)
        CType(Me.NumericUpDown_oversheilds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_dragonKeys.ResumeLayout(False)
        Me.GroupBox_dragonKeys.PerformLayout()
        Me.GroupBox_arcanes.ResumeLayout(False)
        Me.GroupBox_arcanes.PerformLayout()
        CType(Me.NumericUpDown_arcaneUltimatum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_arcaneGuardian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_miscellaneous.ResumeLayout(False)
        Me.GroupBox_miscellaneous.PerformLayout()
        CType(Me.NumericUpDown_enduranceDrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_flow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_coactionDrift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_power.ResumeLayout(False)
        Me.GroupBox_power.PerformLayout()
        CType(Me.NumericUpDown_overextended, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_transientFortitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_intensify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_powerDrift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_blindRage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_energyConversion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_survivability.ResumeLayout(False)
        Me.GroupBox_survivability.PerformLayout()
        CType(Me.NumericUpDown_armoredAgility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_vigor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_healthConversionStacks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_quickThinking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_redirection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_vitality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_healthConversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_steelFiber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_aura.ResumeLayout(False)
        Me.GroupBox_aura.PerformLayout()
        CType(Me.NumericUpDown_growingPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_standUnited, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_physique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomTabControl_abilitys.ResumeLayout(False)
        Me.TabPage_abilitiesDefault.ResumeLayout(False)
        Me.TabPage_abilitiesDefault.PerformLayout()
        Me.TabPage_abilitiesChroma.ResumeLayout(False)
        Me.TabPage_abilitiesChroma.PerformLayout()
        Me.TabPage_abilitiesFrost.ResumeLayout(False)
        Me.TabPage_abilitiesFrost.PerformLayout()
        CType(Me.NumericUpDown_icyAvalanche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesInaros.ResumeLayout(False)
        Me.TabPage_abilitiesInaros.PerformLayout()
        CType(Me.NumericUpDown_scarabSwarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesMesa.ResumeLayout(False)
        Me.TabPage_abilitiesMesa.PerformLayout()
        Me.TabPage_abilitiesMirage.ResumeLayout(False)
        Me.TabPage_abilitiesMirage.PerformLayout()
        Me.TabPage_abilitiesNekros.ResumeLayout(False)
        Me.TabPage_abilitiesNekros.PerformLayout()
        CType(Me.NumericUpDown_shieldOfShadows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesNezha.ResumeLayout(False)
        Me.TabPage_abilitiesNezha.PerformLayout()
        CType(Me.NumericUpDown_wardingHalo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesNidus.ResumeLayout(False)
        Me.TabPage_abilitiesNidus.PerformLayout()
        CType(Me.NumericUpDown_mutationStacks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesOberon.ResumeLayout(False)
        Me.TabPage_abilitiesOberon.PerformLayout()
        Me.TabPage_abilitiesRhino.ResumeLayout(False)
        Me.TabPage_abilitiesRhino.PerformLayout()
        CType(Me.NumericUpDown_ironcladCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_ironSkin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_abilitiesTrinity.ResumeLayout(False)
        Me.TabPage_abilitiesTrinity.PerformLayout()
        Me.TabPage_abilitiesValkyr.ResumeLayout(False)
        Me.TabPage_abilitiesValkyr.PerformLayout()
        Me.GroupBox_focus.ResumeLayout(False)
        Me.GroupBox_focus.PerformLayout()
        Me.TabPage_companion.ResumeLayout(False)
        Me.TabPage_companion.PerformLayout()
        Me.GroupBox_companionResults.ResumeLayout(False)
        Me.GroupBox_companionResults.PerformLayout()
        CType(Me.NumericUpDown_companionStability, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_companionSurvivability.ResumeLayout(False)
        Me.GroupBox_companionSurvivability.PerformLayout()
        CType(Me.NumericUpDown_companionLinkShield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_companionLinkHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_companionLinkArmor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_development.ResumeLayout(False)
        Me.TabPage_development.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl_main As TabControl
    Friend WithEvents TabPage_warframe As TabPage
    Friend WithEvents TabPage_companion As TabPage
    Friend WithEvents ComboBox_warframes As ComboBox
    Friend WithEvents CheckBox_isPrime As CheckBox
    Friend WithEvents CheckBox_isUmbra As CheckBox
    Friend WithEvents Label_author As Label
    Friend WithEvents Icons As ImageList
    Friend WithEvents TabPage_development As TabPage
    Friend WithEvents Label_companions As Label
    Friend WithEvents Label_devPrimeStats As Label
    Friend WithEvents Label_devStats As Label
    Friend WithEvents ComboBox_primeEnergy As ComboBox
    Friend WithEvents ComboBox_primeShield As ComboBox
    Friend WithEvents ComboBox_primeHealth As ComboBox
    Friend WithEvents ComboBox_primeArmor As ComboBox
    Friend WithEvents ComboBox_primeBaseEnergy As ComboBox
    Friend WithEvents ComboBox_primeBaseShield As ComboBox
    Friend WithEvents ComboBox_primeBaseHealth As ComboBox
    Friend WithEvents ComboBox_primeBaseArmor As ComboBox
    Friend WithEvents ComboBox_primes As ComboBox
    Friend WithEvents ComboBox_petShield As ComboBox
    Friend WithEvents ComboBox_petHealth As ComboBox
    Friend WithEvents ComboBox_petArmor As ComboBox
    Friend WithEvents ComboBox_energy As ComboBox
    Friend WithEvents ComboBox_shield As ComboBox
    Friend WithEvents ComboBox_health As ComboBox
    Friend WithEvents ComboBox_armor As ComboBox
    Friend WithEvents ComboBox_baseEnergy As ComboBox
    Friend WithEvents ComboBox_baseShield As ComboBox
    Friend WithEvents ComboBox_baseHealth As ComboBox
    Friend WithEvents ComboBox_baseArmor As ComboBox
    Friend WithEvents GroupBox_aura As GroupBox
    Friend WithEvents NumericUpDown_standUnited As NumericUpDown
    Friend WithEvents RadioButton_standUnited As RadioButton
    Friend WithEvents NumericUpDown_physique As NumericUpDown
    Friend WithEvents RadioButton_physique As RadioButton
    Friend WithEvents NumericUpDown_growingPower As NumericUpDown
    Friend WithEvents RadioButton_growingPower As RadioButton
    Friend WithEvents CheckBox_aura As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox_survivability As CheckBox
    Friend WithEvents GroupBox_survivability As GroupBox
    Friend WithEvents NumericUpDown_healthConversionStacks As NumericUpDown
    Friend WithEvents Label_healthConversionStacks As Label
    Friend WithEvents NumericUpDown_healthConversion As NumericUpDown
    Friend WithEvents CheckBox_healthConversion As CheckBox
    Friend WithEvents NumericUpDown_flow As NumericUpDown
    Friend WithEvents CheckBox_flow As CheckBox
    Friend WithEvents CheckBox_steelFiber As CheckBox
    Friend WithEvents CheckBox_vitality As CheckBox
    Friend WithEvents CheckBox_redirection As CheckBox
    Friend WithEvents NumericUpDown_steelFiber As NumericUpDown
    Friend WithEvents CheckBox_vigor As CheckBox
    Friend WithEvents NumericUpDown_vitality As NumericUpDown
    Friend WithEvents CheckBox_quickThinking As CheckBox
    Friend WithEvents NumericUpDown_redirection As NumericUpDown
    Friend WithEvents NumericUpDown_quickThinking As NumericUpDown
    Friend WithEvents NumericUpDown_vigor As NumericUpDown
    Friend WithEvents NumericUpDown_armoredAgility As NumericUpDown
    Friend WithEvents CheckBox_armoredAgility As CheckBox
    Friend WithEvents CheckBox_power As CheckBox
    Friend WithEvents GroupBox_power As GroupBox
    Friend WithEvents CheckBox_miscellaneous As CheckBox
    Friend WithEvents GroupBox_miscellaneous As GroupBox
    Friend WithEvents NumericUpDown_enduranceDrift As NumericUpDown
    Friend WithEvents CheckBox_enduranceDrift As CheckBox
    Friend WithEvents NumericUpDown_coactionDrift As NumericUpDown
    Friend WithEvents CheckBox_coactionDrift As CheckBox
    Friend WithEvents Label_love As Label
    Friend WithEvents NumericUpDown_blindRage As NumericUpDown
    Friend WithEvents CheckBox_blindRage As CheckBox
    Friend WithEvents NumericUpDown_powerDrift As NumericUpDown
    Friend WithEvents CheckBox_powerDrift As CheckBox
    Friend WithEvents NumericUpDown_energyConversion As NumericUpDown
    Friend WithEvents CheckBox_energyConversion As CheckBox
    Friend WithEvents NumericUpDown_intensify As NumericUpDown
    Friend WithEvents CheckBox_intensify As CheckBox
    Friend WithEvents NumericUpDown_transientFortitude As NumericUpDown
    Friend WithEvents CheckBox_transientFortitude As CheckBox
    Friend WithEvents NumericUpDown_overextended As NumericUpDown
    Friend WithEvents CheckBox_overextended As CheckBox
    Friend WithEvents CheckBox_arcanes As CheckBox
    Friend WithEvents GroupBox_arcanes As GroupBox
    Friend WithEvents CheckBox_dragonKeys As CheckBox
    Friend WithEvents GroupBox_dragonKeys As GroupBox
    Friend WithEvents RadioButton_decayingKey As RadioButton
    Friend WithEvents RadioButton_bleedingKey As RadioButton
    Friend WithEvents CheckBox_arcaneGuardian As CheckBox
    Friend WithEvents NumericUpDown_arcaneUltimatum As NumericUpDown
    Friend WithEvents NumericUpDown_arcaneGuardian As NumericUpDown
    Friend WithEvents CheckBox_arcaneUltimatum As CheckBox
    Friend WithEvents CustomTabControl_abilitys As CustomTabControl
    Friend WithEvents CheckBox_abilities As CheckBox
    Friend WithEvents TabPage_abilitiesChroma As TabPage
    Friend WithEvents RadioButton_fireChroma As RadioButton
    Friend WithEvents RadioButton_iceChroma As RadioButton
    Friend WithEvents RadioButton_electricChroma As RadioButton
    Friend WithEvents CheckBox_elementalWard As CheckBox
    Friend WithEvents CheckBox_vexArmor As CheckBox
    Friend WithEvents TabPage_abilitiesDefault As TabPage
    Friend WithEvents Label_abilityPlaceholder As Label
    Friend WithEvents TabPage_abilitiesFrost As TabPage
    Friend WithEvents CheckBox_icyAvalanche As CheckBox
    Friend WithEvents Panel_Ruler As Panel
    Friend WithEvents TabPage_abilitiesInaros As TabPage
    Friend WithEvents CheckBox_scarabSwarm As CheckBox
    Friend WithEvents TabPage_abilitiesNezha As TabPage
    Friend WithEvents CheckBox_wardingHalo As CheckBox
    Friend WithEvents TabPage_abilitiesOberon As TabPage
    Friend WithEvents CheckBox_ironRenewal As CheckBox
    Friend WithEvents TabPage_abilitiesMesa As TabPage
    Friend WithEvents CheckBox_shatterShield As CheckBox
    Friend WithEvents TabPage_abilitiesRhino As TabPage
    Friend WithEvents CheckBox_ironcladCharge As CheckBox
    Friend WithEvents TabPage_abilitiesValkyr As TabPage
    Friend WithEvents CheckBox_warcry As CheckBox
    Friend WithEvents TabPage_abilitiesNidus As TabPage
    Friend WithEvents CheckBox_mutationStacks As CheckBox
    Friend WithEvents NumericUpDown_mutationStacks As NumericUpDown
    Friend WithEvents CheckBox_focus As CheckBox
    Friend WithEvents GroupBox_focus As GroupBox
    Friend WithEvents Label_focusPlaceholder As Label
    Friend WithEvents TabPage_abilitiesNekros As TabPage
    Friend WithEvents CheckBox_shieldOfShadows As CheckBox
    Friend WithEvents TabPage_abilitiesTrinity As TabPage
    Friend WithEvents NumericUpDown_shieldOfShadows As NumericUpDown
    Friend WithEvents CheckBox_link As CheckBox
    Friend WithEvents CheckBox_blessing As CheckBox
    Friend WithEvents CheckBox_oversheilds As CheckBox
    Friend WithEvents GroupBox_oversheilds As GroupBox
    Friend WithEvents NumericUpDown_oversheilds As NumericUpDown
    Friend WithEvents CheckBox_arcaneHelmets As CheckBox
    Friend WithEvents CustomTabControl_arcaneHelmets As CustomTabControl
    Friend WithEvents TabPage_arcaneHelmetsAsh As TabPage
    Friend WithEvents TabPage_arcaneHelmetsBanshee As TabPage
    Friend WithEvents TabPage_arcaneHelmetsDefault As TabPage
    Friend WithEvents TabPage_arcaneHelmetsEmber As TabPage
    Friend WithEvents TabPage_arcaneHelmetsExcalibur As TabPage
    Friend WithEvents TabPage_arcaneHelmetsFrost As TabPage
    Friend WithEvents TabPage_arcaneHelmetsLoki As TabPage
    Friend WithEvents TabPage_arcaneHelmetsMag As TabPage
    Friend WithEvents TabPage_arcaneHelmetsNyx As TabPage
    Friend WithEvents TabPage_arcaneHelmetsRhino As TabPage
    Friend WithEvents TabPage_arcaneHelmetsSaryn As TabPage
    Friend WithEvents TabPage_arcaneHelmetsTrinity As TabPage
    Friend WithEvents TabPage_arcaneHelmetsVauban As TabPage
    Friend WithEvents TabPage_arcaneHelmetsVolt As TabPage
    Friend WithEvents Label_arcaneHelmetPlaceholder As Label
    Friend WithEvents GroupBox_warframeResults As GroupBox
    Friend WithEvents Label_warframeArmor As Label
    Friend WithEvents TextBox_warframeArmor As TextBox
    Friend WithEvents Label_warframeHealth As Label
    Friend WithEvents TextBox_warframeHealth As TextBox
    Friend WithEvents Label_warframeShield As Label
    Friend WithEvents TextBox_warframeShield As TextBox
    Friend WithEvents Label_warframeEnergy As Label
    Friend WithEvents TextBox_warframeEnergy As TextBox
    Friend WithEvents Label_warframeEHP As Label
    Friend WithEvents TextBox_warframeEHP As TextBox
    Friend WithEvents RadioButton_locustHelmet As RadioButton
    Friend WithEvents ComboBox_companions As ComboBox
    Friend WithEvents Label_devUmbraStats As Label
    Friend WithEvents ComboBox_umbraEnergy As ComboBox
    Friend WithEvents ComboBox_umbraShield As ComboBox
    Friend WithEvents ComboBox_umbraHealth As ComboBox
    Friend WithEvents ComboBox_umbraArmor As ComboBox
    Friend WithEvents ComboBox_umbraBaseEnergy As ComboBox
    Friend WithEvents ComboBox_umbraBaseShield As ComboBox
    Friend WithEvents ComboBox_umbraBaseHealth As ComboBox
    Friend WithEvents ComboBox_umbraBaseArmor As ComboBox
    Friend WithEvents ComboBox_umbras As ComboBox
    Friend WithEvents TabPage_arcaneHelmetsNova As TabPage
    Friend WithEvents Panel_RulerTwo As Panel
    Friend WithEvents RadioButton_reverbHelmet As RadioButton
    Friend WithEvents RadioButton_backdraftHelmet As RadioButton
    Friend WithEvents RadioButton_phoenixHelmet As RadioButton
    Friend WithEvents RadioButton_pendragonHelmet As RadioButton
    Friend WithEvents RadioButton_avalonHelmet As RadioButton
    Friend WithEvents RadioButton_auroraHelmet As RadioButton
    Friend WithEvents RadioButton_squallHelmet As RadioButton
    Friend WithEvents RadioButton_essenceHelmet As RadioButton
    Friend WithEvents RadioButton_swindleHelmet As RadioButton
    Friend WithEvents RadioButton_coilHelmet As RadioButton
    Friend WithEvents RadioButton_gaussHelmet As RadioButton
    Friend WithEvents RadioButton_fluxHelmet As RadioButton
    Friend WithEvents RadioButton_menticideHelmet As RadioButton
    Friend WithEvents RadioButton_vespaHelmet As RadioButton
    Friend WithEvents RadioButton_thrak As RadioButton
    Friend WithEvents RadioButton_hemlockHelmet As RadioButton
    Friend WithEvents RadioButton_auraHelmet As RadioButton
    Friend WithEvents RadioButton_meridianHelmet As RadioButton
    Friend WithEvents RadioButton_espritHelmet As RadioButton
    Friend WithEvents RadioButton_pulseHelmet As RadioButton
    Friend WithEvents RadioButton_vanguardHelmet As RadioButton
    Friend WithEvents RadioButton_stormHelmet As RadioButton
    Friend WithEvents Label_warframePowerStrength As Label
    Friend WithEvents TextBox_warframePowerStrength As TextBox
    Friend WithEvents ComboBox_power As ComboBox
    Friend WithEvents ComboBox_basePower As ComboBox
    Friend WithEvents ComboBox_umbraPower As ComboBox
    Friend WithEvents ComboBox_umbraBasePower As ComboBox
    Friend WithEvents ComboBox_primePower As ComboBox
    Friend WithEvents ComboBox_primeBasePower As ComboBox
    Friend WithEvents NumericUpDown_scarabSwarm As NumericUpDown
    Friend WithEvents CheckBox_hallowedReckoning As CheckBox
    Friend WithEvents NumericUpDown_ironcladCharge As NumericUpDown
    Friend WithEvents CheckBox_ironSkin As CheckBox
    Friend WithEvents TabPage_abilitiesMirage As TabPage
    Friend WithEvents CheckBox_eclipse As CheckBox
    Friend WithEvents NumericUpDown_icyAvalanche As NumericUpDown
    Friend WithEvents Label_wardingHalo As Label
    Friend WithEvents NumericUpDown_wardingHalo As NumericUpDown
    Friend WithEvents Label_ironSkin As Label
    Friend WithEvents NumericUpDown_ironSkin As NumericUpDown
    Friend WithEvents CheckBox_companionPrimeCollar As CheckBox
    Friend WithEvents CheckBox_companionSurvivability As CheckBox
    Friend WithEvents GroupBox_companionSurvivability As GroupBox
    Friend WithEvents CheckBox_companionLinkShield As CheckBox
    Friend WithEvents NumericUpDown_companionLinkShield As NumericUpDown
    Friend WithEvents CheckBox_companionLinkHealth As CheckBox
    Friend WithEvents NumericUpDown_companionLinkHealth As NumericUpDown
    Friend WithEvents CheckBox_companionLinkArmor As CheckBox
    Friend WithEvents NumericUpDown_companionLinkArmor As NumericUpDown
    Friend WithEvents NumericUpDown_companionStability As NumericUpDown
    Friend WithEvents Label_companionStability As Label
    Friend WithEvents GroupBox_companionResults As GroupBox
    Friend WithEvents TextBox_companionArmor As TextBox
    Friend WithEvents Label_companionShield As Label
    Friend WithEvents TextBox_companionShield As TextBox
    Friend WithEvents Label_companionHealth As Label
    Friend WithEvents TextBox_companionHealth As TextBox
    Friend WithEvents Label_companionArmor As Label
    Friend WithEvents Label_companionEHP As Label
    Friend WithEvents TextBox_companionEHP As TextBox
End Class