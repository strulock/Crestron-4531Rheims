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
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=TSTAT Temp Display v1.1.0 (cm)
  SmplCName=tstat temp display v1.1.csp
  Code=1
  SysRev5=3.090
  SMWRev=2.02.00
  InputCue1=show_half_degrees
  InputSigType1=Digital
  InputCue2=hide_value
  InputSigType2=Digital
  InputList2Cue1=temperature_in_tenths
  InputList2SigType1=Analog
  InputList2Cue2=append_chars
  InputList2SigType2=Serial
  OutputList2Cue1=temperature_display$
  OutputList2SigType1=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=2
  MaxVariableInputs=2
  MinVariableInputsList2=2
  MaxVariableInputsList2=2
  MinVariableOutputs=0
  MaxVariableOutputs=0
  MinVariableOutputsList2=1
  MaxVariableOutputsList2=1
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
  SPlus2CompiledName=S2_tstat_temp_display_v1_1
  SymJam=NonExclusive
  FileName=tstat temp display v1.1.csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
