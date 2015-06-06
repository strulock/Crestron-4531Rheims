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

namespace CrestronModule_SWAMP_AUDIO_ZONE_PROCESSOR_V1_0_0
{
    public class CrestronModuleClass_SWAMP_AUDIO_ZONE_PROCESSOR_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMSTARTUPPULSE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTPOSITION;
        Crestron.Logos.SplusObjects.AnalogOutput INITIALPREVIOUSSOURCE;
        object SYSTEMSTARTUPPULSE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                ushort TEMPPREVIOUSSOURCE = 0;
                
                
                __context__.SourceCodeLine = 49;
                TEMPPREVIOUSSOURCE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 51;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)24; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 53;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < LISTPOSITION[ I ] .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LISTPOSITION[ I ] .UshortValue <= 24 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 55;
                        TEMPPREVIOUSSOURCE = (ushort) ( LISTPOSITION[ I ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 56;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 51;
                    } 
                
                __context__.SourceCodeLine = 60;
                INITIALPREVIOUSSOURCE  .Value = (ushort) ( TEMPPREVIOUSSOURCE ) ; 
                
                
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
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SYSTEMSTARTUPPULSE = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMSTARTUPPULSE__DigitalInput__, this );
        m_DigitalInputList.Add( SYSTEMSTARTUPPULSE__DigitalInput__, SYSTEMSTARTUPPULSE );
        
        LISTPOSITION = new InOutArray<AnalogInput>( 24, this );
        for( uint i = 0; i < 24; i++ )
        {
            LISTPOSITION[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION__AnalogSerialInput__, this );
            m_AnalogInputList.Add( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION[i+1] );
        }
        
        INITIALPREVIOUSSOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( INITIALPREVIOUSSOURCE__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( INITIALPREVIOUSSOURCE__AnalogSerialOutput__, INITIALPREVIOUSSOURCE );
        
        
        SYSTEMSTARTUPPULSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMSTARTUPPULSE_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_SWAMP_AUDIO_ZONE_PROCESSOR_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SYSTEMSTARTUPPULSE__DigitalInput__ = 0;
    const uint LISTPOSITION__AnalogSerialInput__ = 0;
    const uint INITIALPREVIOUSSOURCE__AnalogSerialOutput__ = 0;
    
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
