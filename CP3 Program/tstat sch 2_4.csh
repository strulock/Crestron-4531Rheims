[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.21
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
  Cmn1=This module is designed to be used from within the "CHV-T(H)STAT||1
  Cmn2=with 5/2 Schedule" modules.\\Please see the help included with those||1
  Cmn3=modules for more information.\\\\Revision History\\================\\
  Cmn4=v2.3.1\\------\\-fixed issue where setpoint is not saved properly\\
  Cmn5=\\v2.3.0\\------\\-added auto 1pt support for scheduler.\\-Added||1
  Cmn6=deadband when setting scheduler setpoints.\\-Fix bug where the Away||1
  Cmn7=Schedule setpoint did not update if you're in away mode and change\\
  Cmn8=||1the setpoint.\\\\v2.2.0\\------\\-Added Digital Inputs to increase||1
  Cmn9=time by 15 minute increments.\\\\v2.1.2\\------\\-Bug fix for TSTATRF||1
  Cmn10=entering Away mode at startup if an old schedule file is present\\
  Cmn11=\\v2.1.1\\------\\-Initialized g_TodayJDay at startup to prevent||1
  Cmn12=errors.\\\\v2.1.0\\------\\-Added Scheduled Heat\Cool\Slab\Auto(1pt)||1
  Cmn13=Setpoints\\\\v2.0.0\\------\\-Added support to automatically return||1
  Cmn14=from Away Mode at specified time and date.\\-Added support for Slab||1
  Cmn15=Modes\\-Added support to retain Hold and Away states after power||1
  Cmn16=outage or new program upload.\\\\\\v1.0.3\\------\\-fixed bug where||1
  Cmn17=schedules would not consistently run when there was only one schedule||1
  Cmn18=defined per day\\\\v1.0.2\\------\\-fixed bug where the "removed"||1
  Cmn19=schedules could run after midnight in certain cases\\-improved handling||1
  Cmn20=of cases where ALL schedules were removed (hitting Run_Program would||1
  Cmn21=change setpoints)\\-added "No Schedules" text on Current_Schedule$||1
  Cmn22=if ALL schedules were removed\\\\v1.0.1\\------\\-fixed bug involving||1
  Cmn23=adjusting schedule times on the TSTAT unit. Time would not properly||1
  Cmn24=wrap from PM to AM after midnight, or vice versa\\\\v1.0.0\\----
  Cmn25=--\\-initial release\\
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=tstat sch 2_4 (cm)
  SmplCName=tstat sch 2_4.csp
  Code=1
  SysRev5=3.090
  SMWRev=2.02.00
  InputCue1=weekday_wake
  InputSigType1=Digital
  InputCue2=weekday_leave
  InputSigType2=Digital
  InputCue3=weekday_return
  InputSigType3=Digital
  InputCue4=weekday_sleep
  InputSigType4=Digital
  InputCue5=weekend_wake
  InputSigType5=Digital
  InputCue6=weekend_leave
  InputSigType6=Digital
  InputCue7=weekend_return
  InputSigType7=Digital
  InputCue8=weekend_sleep
  InputSigType8=Digital
  InputCue9=away
  InputSigType9=Digital
  InputCue10=time_up
  InputSigType10=Digital
  InputCue11=time_down
  InputSigType11=Digital
  InputCue12=hour_up
  InputSigType12=Digital
  InputCue13=hour_down
  InputSigType13=Digital
  InputCue14=minute_up
  InputSigType14=Digital
  InputCue15=minute_down
  InputSigType15=Digital
  InputCue16=heat_setpoint_up
  InputSigType16=Digital
  InputCue17=heat_setpoint_down
  InputSigType17=Digital
  InputCue18=cool_setpoint_up
  InputSigType18=Digital
  InputCue19=cool_setpoint_down
  InputSigType19=Digital
  InputCue20=slab_setpoint_up
  InputSigType20=Digital
  InputCue21=slab_setpoint_down
  InputSigType21=Digital
  InputCue22=auto_setpoint_up
  InputSigType22=Digital
  InputCue23=auto_setpoint_down
  InputSigType23=Digital
  InputCue24=remove_schedule
  InputSigType24=Digital
  InputCue25=reset_schedules
  InputSigType25=Digital
  InputCue26=temp_scale
  InputSigType26=Digital
  InputCue27=half_degree_C_steps
  InputSigType27=Digital
  InputCue28=run_program
  InputSigType28=Digital
  InputCue29=run_away
  InputSigType29=Digital
  InputCue30=run_hold
  InputSigType30=Digital
  InputCue31=single_button_select
  InputSigType31=Digital
  InputCue32=single_button_adjust
  InputSigType32=Digital
  InputCue33=use_default_schedule_times
  InputSigType33=Digital
  InputCue34=sunday_night_is_weekday
  InputSigType34=Digital
  InputCue35=friday_night_is_weekend
  InputSigType35=Digital
  InputCue36=AwayDay_inc
  InputSigType36=Digital
  InputCue37=AwayDay_dec
  InputSigType37=Digital
  InputCue38=AwaySched_inc
  InputSigType38=Digital
  InputCue39=Slab_SP_Enabled
  InputSigType39=Digital
  InputCue40=Auto_Mode_Enabled
  InputSigType40=Digital
  OutputCue1=schedule_due
  OutputSigType1=Digital
  OutputCue2=PM_fb
  OutputSigType2=Digital
  OutputCue3=RUN
  OutputSigType3=Digital
  OutputCue4=Away_Mode_fb
  OutputSigType4=Digital
  OutputCue5=Hold_Mode_fb
  OutputSigType5=Digital
  InputList2Cue1=current_heat_SP
  InputList2SigType1=Analog
  InputList2Cue2=current_cool_SP
  InputList2SigType2=Analog
  InputList2Cue3=current_slab_SP
  InputList2SigType3=Analog
  InputList2Cue4=current_auto_SP
  InputList2SigType4=Analog
  InputList2Cue5=instance_id
  InputList2SigType5=Analog
  InputList2Cue6=path$
  InputList2SigType6=Serial
  InputList2Cue7=ScheduledHeatSetpoint
  InputList2SigType7=Analog
  InputList2Cue8=ScheduledCoolSetpoint
  InputList2SigType8=Analog
  InputList2Cue9=ScheduledSlabSetpoint
  InputList2SigType9=Analog
  InputList2Cue10=ScheduledAutoSetpoint
  InputList2SigType10=Analog
  InputList2Cue11=DeadBand
  InputList2SigType11=Analog
  OutputList2Cue1=current_schedule
  OutputList2SigType1=Analog
  OutputList2Cue2=current_dayofweek
  OutputList2SigType2=Analog
  OutputList2Cue3=schedule_name$
  OutputList2SigType3=Serial
  OutputList2Cue4=schedule_time$
  OutputList2SigType4=Serial
  OutputList2Cue5=single_button_select$
  OutputList2SigType5=Serial
  OutputList2Cue6=single_button_adjust$
  OutputList2SigType6=Serial
  OutputList2Cue7=Away_Schedule$
  OutputList2SigType7=Serial
  OutputList2Cue8=Away_Date$
  OutputList2SigType8=Serial
  OutputList2Cue9=Away_Schedule_Short$
  OutputList2SigType9=Serial
  OutputList2Cue10=Away_Date_Short$
  OutputList2SigType10=Serial
  OutputList2Cue11=schedule_setpoint$[1]
  OutputList2SigType11=Serial
  OutputList2Cue12=schedule_setpoint$[2]
  OutputList2SigType12=Serial
  OutputList2Cue13=schedule_setpoint$[3]
  OutputList2SigType13=Serial
  OutputList2Cue14=schedule_setpoint$[4]
  OutputList2SigType14=Serial
  OutputList2Cue15=setpoint[#]
  OutputList2SigType15=Analog
  ParamCue1=[Reference Name]
  MinVariableInputs=40
  MaxVariableInputs=40
  MinVariableInputsList2=11
  MaxVariableInputsList2=11
  MinVariableOutputs=5
  MaxVariableOutputs=5
  MinVariableOutputsList2=15
  MaxVariableOutputsList2=18
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=0
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_tstat_sch_2_4
  SymJam=NonExclusive
  FileName=tstat sch 2_4.csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
