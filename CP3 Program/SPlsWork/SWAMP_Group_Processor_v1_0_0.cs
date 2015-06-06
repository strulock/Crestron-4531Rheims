using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_SWAMP_GROUP_PROCESSOR_V1_0_0
{
    public class CrestronModuleClass_SWAMP_GROUP_PROCESSOR_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PROCESS;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> GROUPNAMESIN;
        InOutArray<Crestron.Logos.SplusObjects.BufferInput> GROUPLISTIN;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMNAMEVALID;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPSINITIALIZED;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTGROUP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ROOMOUT;
        private void RESETOUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 64;
            CURRENTGROUP  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 65;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 67;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)72; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                {
                __context__.SourceCodeLine = 68;
                ROOMOUT [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 67;
                }
            
            __context__.SourceCodeLine = 70;
            ROOMNAMEVALID  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object PROCESS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                ushort ROOMNUMBER = 0;
                
                CrestronString TEMPNUMBERSTRING;
                TEMPNUMBERSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
                
                
                __context__.SourceCodeLine = 79;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)6; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 81;
                    CURRENTGROUP  .Value = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 82;
                    Functions.ProcessLogic ( ) ; 
                    __context__.SourceCodeLine = 84;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < Functions.Length( GROUPLISTIN[ I ] ) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( 0 < Functions.Atoi( GROUPLISTIN[ I ] ) ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 86;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "," , GROUPLISTIN[ I ] ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 88;
                            TEMPNUMBERSTRING  .UpdateValue ( Functions.Remove ( "," , GROUPLISTIN [ I ] )  ) ; 
                            __context__.SourceCodeLine = 89;
                            ROOMNUMBER = (ushort) ( Functions.Atoi( TEMPNUMBERSTRING ) ) ; 
                            __context__.SourceCodeLine = 90;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < ROOMNUMBER ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ROOMNUMBER <= 72 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 91;
                                ROOMOUT [ ROOMNUMBER]  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 95;
                            ROOMNUMBER = (ushort) ( Functions.Atoi( GROUPLISTIN[ I ] ) ) ; 
                            __context__.SourceCodeLine = 96;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < ROOMNUMBER ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ROOMNUMBER <= 72 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 97;
                                ROOMOUT [ ROOMNUMBER]  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 98;
                            break ; 
                            } 
                        
                        __context__.SourceCodeLine = 84;
                        } 
                    
                    __context__.SourceCodeLine = 102;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( 0 < Functions.Length( GROUPNAMESIN[ I ] ) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 103;
                        ROOMNAMEVALID  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 105;
                    Functions.ProcessLogic ( ) ; 
                    __context__.SourceCodeLine = 106;
                    RESETOUTPUTS (  __context__  ) ; 
                    __context__.SourceCodeLine = 79;
                    } 
                
                __context__.SourceCodeLine = 109;
                GROUPSINITIALIZED  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 114;
            GROUPSINITIALIZED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 115;
            RESETOUTPUTS (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        
        PROCESS = new Crestron.Logos.SplusObjects.DigitalInput( PROCESS__DigitalInput__, this );
        m_DigitalInputList.Add( PROCESS__DigitalInput__, PROCESS );
        
        ROOMNAMEVALID = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMNAMEVALID__DigitalOutput__, this );
        m_DigitalOutputList.Add( ROOMNAMEVALID__DigitalOutput__, ROOMNAMEVALID );
        
        GROUPSINITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPSINITIALIZED__DigitalOutput__, this );
        m_DigitalOutputList.Add( GROUPSINITIALIZED__DigitalOutput__, GROUPSINITIALIZED );
        
        ROOMOUT = new InOutArray<DigitalOutput>( 72, this );
        for( uint i = 0; i < 72; i++ )
        {
            ROOMOUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMOUT__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( ROOMOUT__DigitalOutput__ + i, ROOMOUT[i+1] );
        }
        
        CURRENTGROUP = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTGROUP__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CURRENTGROUP__AnalogSerialOutput__, CURRENTGROUP );
        
        GROUPNAMESIN = new InOutArray<StringInput>( 6, this );
        for( uint i = 0; i < 6; i++ )
        {
            GROUPNAMESIN[i+1] = new Crestron.Logos.SplusObjects.StringInput( GROUPNAMESIN__AnalogSerialInput__ + i, GROUPNAMESIN__AnalogSerialInput__, 32, this );
            m_StringInputList.Add( GROUPNAMESIN__AnalogSerialInput__ + i, GROUPNAMESIN[i+1] );
        }
        
        GROUPLISTIN = new InOutArray<BufferInput>( 6, this );
        for( uint i = 0; i < 6; i++ )
        {
            GROUPLISTIN[i+1] = new Crestron.Logos.SplusObjects.BufferInput( GROUPLISTIN__AnalogSerialInput__ + i, GROUPLISTIN__AnalogSerialInput__, 300, this );
            m_StringInputList.Add( GROUPLISTIN__AnalogSerialInput__ + i, GROUPLISTIN[i+1] );
        }
        
        
        PROCESS.OnDigitalPush.Add( new InputChangeHandlerWrapper( PROCESS_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_SWAMP_GROUP_PROCESSOR_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint PROCESS__DigitalInput__ = 0;
    const uint GROUPNAMESIN__AnalogSerialInput__ = 0;
    const uint GROUPLISTIN__AnalogSerialInput__ = 6;
    const uint ROOMNAMEVALID__DigitalOutput__ = 0;
    const uint GROUPSINITIALIZED__DigitalOutput__ = 1;
    const uint CURRENTGROUP__AnalogSerialOutput__ = 0;
    const uint ROOMOUT__DigitalOutput__ = 2;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
