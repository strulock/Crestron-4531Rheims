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
  Name=C2N-TXM Guide Engine v4.0 (cm)
  SmplCName=C2N-TXM Guide Engine v4.0.csp
  Code=1
  SysRev5=4.006
  SMWRev=3.00.00
  InputCue1=PowerOnFb
  InputSigType1=Digital
  InputCue2=PoweringOnFb
  InputSigType2=Digital
  InputCue3=ShowCatList
  InputSigType3=Digital
  InputCue4=ShowChannelList
  InputSigType4=Digital
  InputCue5=GenerateFocusList
  InputSigType5=Digital
  InputCue6=ConcatenateStrings
  InputSigType6=Digital
  OutputCue1=IsRegisteredwithDeviceRegistry
  OutputSigType1=Digital
  OutputCue2=PresetFb[#]
  OutputSigType2=Digital
  InputList2Cue1=ShowCategoryChannels
  InputList2SigType1=Analog
  InputList2Cue2=GuideInfo$
  InputList2SigType2=Serial
  InputList2Cue3=GuideRequest$
  InputList2SigType3=Serial
  InputList2Cue4=CurrentChannel
  InputList2SigType4=Analog
  InputList2Cue5=PresetModeFb
  InputList2SigType5=Analog
  InputList2Cue6=Equip_ID
  InputList2SigType6=Analog
  InputList2Cue7=PresetIn[#]
  InputList2SigType7=Analog
  OutputList2Cue1=NewChannel
  OutputList2SigType1=Analog
  OutputList2Cue2=PresetModeOut
  OutputList2SigType2=Analog
  OutputList2Cue3=SatSignalStrengthOut
  OutputList2SigType3=Analog
  OutputList2Cue4=RepSignalStrengthOut
  OutputList2SigType4=Analog
  OutputList2Cue5=GuideResponse$
  OutputList2SigType5=Serial
  OutputList2Cue6=GuideResponse2$
  OutputList2SigType6=Serial
  OutputList2Cue7=GuideResponse3$
  OutputList2SigType7=Serial
  OutputList2Cue8=ActivationNumber$
  OutputList2SigType8=Serial
  OutputList2Cue9=FocusList$
  OutputList2SigType9=Serial
  OutputList2Cue10=TunedChannelNameOut$
  OutputList2SigType10=Serial
  OutputList2Cue11=TunedChannelCategoryOut$
  OutputList2SigType11=Serial
  OutputList2Cue12=TunedChannelSongOut$
  OutputList2SigType12=Serial
  OutputList2Cue13=TunedChannelArtistOut$
  OutputList2SigType13=Serial
  OutputList2Cue14=TunedChannelNumberOut$
  OutputList2SigType14=Serial
  OutputList2Cue15=DiagnosticStringOut$
  OutputList2SigType15=Serial
  OutputList2Cue16=PresetNameOut$[#]
  OutputList2SigType16=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=6
  MaxVariableInputs=6
  MinVariableInputsList2=7
  MaxVariableInputsList2=26
  MinVariableOutputs=2
  MaxVariableOutputs=21
  MinVariableOutputsList2=16
  MaxVariableOutputsList2=35
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
  SPlus2CompiledName=S2_C2N_TXM_Guide_Engine_v4_0
  SymJam=NonExclusive
  FileName=C2N-TXM Guide Engine v4.0.csh
  SIMPLPlusModuleEncoding=0
  clz1=Crestron.SatelliteRadioComInterface
  clz2=AppHelperClasses v2_0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]