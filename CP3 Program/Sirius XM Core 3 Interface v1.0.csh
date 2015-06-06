[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.26
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,362,378,380,405,407,408,409,478,522,537,554,586,590,611,624,718,756,767,830,841,842,854,883,955,1032,1062,1079,1128,1129,1134,1140,1157,1158,1195,1199,1220,1221,1222,1223,1299,1348,1349,1439,1472,1473,1499,1746,1803,1975,2229,2354,2514,2523,2532,2706,2707,3235,3236,3427,3454,3567,3568,3601,3602,3708,3902,3903,3912,3918,3925,3926,4206,4207,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=Sirius XM Core 3 Interface v1.0 (cm)
  SmplCName=Sirius XM Core 3 Interface v1.0.csp
  Code=1
  SysRev5=4.006
  SMWRev=3.00.00
  InputCue1=Tuner_Is_Sirius
  InputSigType1=Digital
  InputCue2=Tuner_Is_XM
  InputSigType2=Digital
  InputCue3=TunerReady
  InputSigType3=Digital
  InputCue4=Now_Playing_Info_Changed
  InputSigType4=Digital
  OutputCue1=Ready
  OutputSigType1=Digital
  OutputCue2=Tune_Down
  OutputSigType2=Digital
  OutputCue3=Tune_Up
  OutputSigType3=Digital
  OutputCue4=Previous_Preset
  OutputSigType4=Digital
  OutputCue5=Next_Preset
  OutputSigType5=Digital
  OutputCue6=Category_Up
  OutputSigType6=Digital
  OutputCue7=Category_Down
  OutputSigType7=Digital
  InputList2Cue1=ModuleID
  InputList2SigType1=Analog
  InputList2Cue2=PIN_In_Use
  InputList2SigType2=Analog
  InputList2Cue3=GuideInfo$
  InputList2SigType3=Serial
  InputList2Cue4=From_Media_Player
  InputList2SigType4=Serial
  InputList2Cue5=CurrentChannelNumber
  InputList2SigType5=Serial
  InputList2Cue6=CurrentChannelName
  InputList2SigType6=Serial
  InputList2Cue7=CurrentChannelCategory
  InputList2SigType7=Serial
  InputList2Cue8=CurrentSong
  InputList2SigType8=Serial
  InputList2Cue9=CurrentArtist
  InputList2SigType9=Serial
  InputList2Cue10=CurrentComposer
  InputList2SigType10=Serial
  OutputList2Cue1=ScrollInfoRequest$
  OutputList2SigType1=Serial
  OutputList2Cue2=To_Media_Player
  OutputList2SigType2=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=4
  MaxVariableInputs=4
  MinVariableInputsList2=10
  MaxVariableInputsList2=10
  MinVariableOutputs=7
  MaxVariableOutputs=7
  MinVariableOutputsList2=2
  MaxVariableOutputsList2=2
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
  SPlus2CompiledName=S2_Sirius_XM_Core_3_Interface_v1_0
  SymJam=NonExclusive
  FileName=Sirius XM Core 3 Interface v1.0.csh
  SIMPLPlusModuleEncoding=0
  clz1=Crestron.SatelliteRadioComInterface
  clz2=Satellite Radio
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
