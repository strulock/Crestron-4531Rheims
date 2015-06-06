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

namespace CrestronModule_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0
{
    public class CrestronModuleClass_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOMCONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput SELECTSINGLESOURCE;
        Crestron.Logos.SplusObjects.AnalogInput SOURCEACTIVEIN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCELINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTPOSITION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> SOURCEICONSIN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NAMEIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE1IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE2IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGTRANSPORTIN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SOURCELISTINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput SOURCELISTHASONEITEM;
        Crestron.Logos.SplusObjects.DigitalOutput SHIFTSOURCEHIGHLIGHTTOTOP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> GOTOSOURCECONTROLPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCEHIGHLIGHTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCESCROLLMAX;
        Crestron.Logos.SplusObjects.AnalogOutput SINGLESOURCEICON;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTSOURCEICON;
        Crestron.Logos.SplusObjects.AnalogOutput SINGLESOURCE;
        Crestron.Logos.SplusObjects.StringOutput SINGLESOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGLINE2;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGTRANSPORT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NAMEOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCEICONSOUT;
        private void REFRESHPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( 0 < SOURCESCROLLMAX  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 90;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SOURCESCROLLMAX  .Value; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 92;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 94;
                        NAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 95;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 99;
                        NAMEOUT__DOLLAR__ [ I]  .UpdateValue ( NAMEIN__DOLLAR__ [ LISTPOSITION[ I ] .UshortValue ]  ) ; 
                        __context__.SourceCodeLine = 100;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( SOURCEICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 102;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == LISTPOSITION[ I ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 104;
                            SOURCEICONSOUT [ I]  .Value = (ushort) ( (SOURCEICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue + 100) ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 108;
                            SOURCEICONSOUT [ I]  .Value = (ushort) ( SOURCEICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 90;
                    } 
                
                __context__.SourceCodeLine = 113;
                SOURCEHIGHLIGHTOUT  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 114;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 116;
                SHIFTSOURCEHIGHLIGHTTOTOP  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 117;
                SHIFTSOURCEHIGHLIGHTTOTOP  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        object ROOMCONNECTED_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                ushort TEMPSCROLLMAX = 0;
                
                
                __context__.SourceCodeLine = 127;
                SOURCELISTINITIALIZED  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 129;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 24 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 131;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 133;
                        TEMPSCROLLMAX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 134;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 129;
                    } 
                
                __context__.SourceCodeLine = 138;
                SOURCESCROLLMAX  .Value = (ushort) ( TEMPSCROLLMAX ) ; 
                __context__.SourceCodeLine = 140;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSCROLLMAX == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 142;
                    SOURCELISTHASONEITEM  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 143;
                    SINGLESOURCEICON  .Value = (ushort) ( SOURCEICONSIN[ LISTPOSITION[ 1 ] .UshortValue ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 144;
                    SINGLESOURCENAME  .UpdateValue ( NAMEIN__DOLLAR__ [ LISTPOSITION[ 1 ] .UshortValue ]  ) ; 
                    __context__.SourceCodeLine = 145;
                    SINGLESOURCE  .Value = (ushort) ( LISTPOSITION[ 1 ] .UshortValue ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 149;
                    SOURCELISTHASONEITEM  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 150;
                    SINGLESOURCEICON  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 151;
                    SINGLESOURCE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 154;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 156;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 158;
                    CURRENTSOURCEICON  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 159;
                    CURRENTSOURCENAME  .UpdateValue ( "Room Is Off"  ) ; 
                    __context__.SourceCodeLine = 160;
                    CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 161;
                    CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 162;
                    CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 166;
                    CURRENTSOURCEICON  .Value = (ushort) ( SOURCEICONSIN[ SOURCEACTIVEIN  .UshortValue ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 167;
                    CURRENTSOURCENAME  .UpdateValue ( NAMEIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                    __context__.SourceCodeLine = 168;
                    CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                    __context__.SourceCodeLine = 169;
                    CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                    __context__.SourceCodeLine = 170;
                    CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                    } 
                
                __context__.SourceCodeLine = 173;
                SOURCELISTINITIALIZED  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SELECTSINGLESOURCE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCESCROLLMAX  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 183;
                    SOURCESELECTED [ LISTPOSITION[ 1 ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 184;
                    SOURCESELECTED [ LISTPOSITION[ 1 ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 186;
                    GOTOSOURCECONTROLPAGE [ LISTPOSITION[ 1 ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 187;
                    GOTOSOURCECONTROLPAGE [ LISTPOSITION[ 1 ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SOURCEACTIVEIN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 197;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 199;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SOURCESCROLLMAX  .Value; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 201;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == LISTPOSITION[ I ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 202;
                    SOURCEICONSOUT [ I]  .Value = (ushort) ( (SOURCEICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue + 100) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 203;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 204;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 206;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( SOURCEICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue ) ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 199;
                } 
            
            } 
        
        __context__.SourceCodeLine = 210;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 212;
            CURRENTSOURCEICON  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 213;
            CURRENTSOURCENAME  .UpdateValue ( "Room Is Off"  ) ; 
            __context__.SourceCodeLine = 214;
            CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 215;
            CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 216;
            CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( ""  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 220;
            CURRENTSOURCEICON  .Value = (ushort) ( SOURCEICONSIN[ SOURCEACTIVEIN  .UshortValue ] .UshortValue ) ; 
            __context__.SourceCodeLine = 221;
            CURRENTSOURCENAME  .UpdateValue ( NAMEIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 222;
            CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 223;
            CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 224;
            CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCELINESELECTED_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        
        __context__.SourceCodeLine = 233;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 235;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 237;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ SELECTEDLINE ] .UshortValue != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 239;
                SOURCESELECTED [ LISTPOSITION[ SELECTEDLINE ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 240;
                SOURCESELECTED [ LISTPOSITION[ SELECTEDLINE ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 242;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ SELECTEDLINE ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 243;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ SELECTEDLINE ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE1IN__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMCHANGED = 0;
        
        
        __context__.SourceCodeLine = 253;
        ITEMCHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 255;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 257;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMCHANGED == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 259;
                CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE2IN__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMCHANGED = 0;
        
        
        __context__.SourceCodeLine = 269;
        ITEMCHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 271;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 273;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMCHANGED == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 275;
                CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMCHANGED = 0;
        
        
        __context__.SourceCodeLine = 285;
        ITEMCHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 287;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 289;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMCHANGED == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 291;
                CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 301;
        SOURCESCROLLMAX  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 303;
        CURRENTSOURCEICON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 304;
        CURRENTSOURCENAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 305;
        CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 306;
        CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 307;
        CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 309;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)24; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 311;
            SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 309;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ROOMCONNECTED = new Crestron.Logos.SplusObjects.DigitalInput( ROOMCONNECTED__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMCONNECTED__DigitalInput__, ROOMCONNECTED );
    
    SELECTSINGLESOURCE = new Crestron.Logos.SplusObjects.DigitalInput( SELECTSINGLESOURCE__DigitalInput__, this );
    m_DigitalInputList.Add( SELECTSINGLESOURCE__DigitalInput__, SELECTSINGLESOURCE );
    
    SOURCELINESELECTED = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCELINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCELINESELECTED__DigitalInput__ + i, SOURCELINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCELINESELECTED__DigitalInput__ + i, SOURCELINESELECTED[i+1] );
    }
    
    SOURCELISTINITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCELISTINITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURCELISTINITIALIZED__DigitalOutput__, SOURCELISTINITIALIZED );
    
    SOURCELISTHASONEITEM = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCELISTHASONEITEM__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURCELISTHASONEITEM__DigitalOutput__, SOURCELISTHASONEITEM );
    
    SHIFTSOURCEHIGHLIGHTTOTOP = new Crestron.Logos.SplusObjects.DigitalOutput( SHIFTSOURCEHIGHLIGHTTOTOP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHIFTSOURCEHIGHLIGHTTOTOP__DigitalOutput__, SHIFTSOURCEHIGHLIGHTTOTOP );
    
    SOURCESELECTED = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCESELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCESELECTED__DigitalOutput__ + i, SOURCESELECTED[i+1] );
    }
    
    GOTOSOURCECONTROLPAGE = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        GOTOSOURCECONTROLPAGE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOSOURCECONTROLPAGE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( GOTOSOURCECONTROLPAGE__DigitalOutput__ + i, GOTOSOURCECONTROLPAGE[i+1] );
    }
    
    SOURCEACTIVEIN = new Crestron.Logos.SplusObjects.AnalogInput( SOURCEACTIVEIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCEACTIVEIN__AnalogSerialInput__, SOURCEACTIVEIN );
    
    LISTPOSITION = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        LISTPOSITION[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION[i+1] );
    }
    
    SOURCEICONSIN = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCEICONSIN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( SOURCEICONSIN__AnalogSerialInput__ + i, SOURCEICONSIN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( SOURCEICONSIN__AnalogSerialInput__ + i, SOURCEICONSIN[i+1] );
    }
    
    SOURCEHIGHLIGHTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCEHIGHLIGHTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCEHIGHLIGHTOUT__AnalogSerialOutput__, SOURCEHIGHLIGHTOUT );
    
    SOURCESCROLLMAX = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESCROLLMAX__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCESCROLLMAX__AnalogSerialOutput__, SOURCESCROLLMAX );
    
    SINGLESOURCEICON = new Crestron.Logos.SplusObjects.AnalogOutput( SINGLESOURCEICON__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SINGLESOURCEICON__AnalogSerialOutput__, SINGLESOURCEICON );
    
    CURRENTSOURCEICON = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTSOURCEICON__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENTSOURCEICON__AnalogSerialOutput__, CURRENTSOURCEICON );
    
    SINGLESOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( SINGLESOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SINGLESOURCE__AnalogSerialOutput__, SINGLESOURCE );
    
    SOURCEICONSOUT = new InOutArray<AnalogOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCEICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCEICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCEICONSOUT__AnalogSerialOutput__ + i, SOURCEICONSOUT[i+1] );
    }
    
    NAMEIN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        NAMEIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( NAMEIN__DOLLAR____AnalogSerialInput__ + i, NAMEIN__DOLLAR____AnalogSerialInput__, 32, this );
        m_StringInputList.Add( NAMEIN__DOLLAR____AnalogSerialInput__ + i, NAMEIN__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGLINE1IN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        NOWPLAYINGLINE1IN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGLINE1IN__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGLINE2IN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        NOWPLAYINGLINE2IN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__, 100, this );
        m_StringInputList.Add( NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGLINE2IN__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGTRANSPORTIN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        NOWPLAYINGTRANSPORTIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__, 1, this );
        m_StringInputList.Add( NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__ + i, NOWPLAYINGTRANSPORTIN__DOLLAR__[i+1] );
    }
    
    SINGLESOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( SINGLESOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SINGLESOURCENAME__AnalogSerialOutput__, SINGLESOURCENAME );
    
    CURRENTSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENAME__AnalogSerialOutput__, CURRENTSOURCENAME );
    
    CURRENTSOURCENOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGLINE1 );
    
    CURRENTSOURCENOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGLINE2 );
    
    CURRENTSOURCENOWPLAYINGTRANSPORT = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGTRANSPORT );
    
    NAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        NAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NAMEOUT__DOLLAR____AnalogSerialOutput__ + i, NAMEOUT__DOLLAR__[i+1] );
    }
    
    
    ROOMCONNECTED.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOMCONNECTED_OnChange_0, false ) );
    SELECTSINGLESOURCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECTSINGLESOURCE_OnPush_1, false ) );
    SOURCEACTIVEIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCEACTIVEIN_OnChange_2, false ) );
    for( uint i = 0; i < 24; i++ )
        SOURCELINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCELINESELECTED_OnPush_3, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE1IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE1IN__DOLLAR___OnChange_4, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE2IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE2IN__DOLLAR___OnChange_5, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGTRANSPORTIN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_6, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOMCONNECTED__DigitalInput__ = 0;
const uint SELECTSINGLESOURCE__DigitalInput__ = 1;
const uint SOURCEACTIVEIN__AnalogSerialInput__ = 0;
const uint SOURCELINESELECTED__DigitalInput__ = 2;
const uint LISTPOSITION__AnalogSerialInput__ = 1;
const uint SOURCEICONSIN__AnalogSerialInput__ = 25;
const uint NAMEIN__DOLLAR____AnalogSerialInput__ = 49;
const uint NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__ = 73;
const uint NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__ = 97;
const uint NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__ = 121;
const uint SOURCELISTINITIALIZED__DigitalOutput__ = 0;
const uint SOURCELISTHASONEITEM__DigitalOutput__ = 1;
const uint SHIFTSOURCEHIGHLIGHTTOTOP__DigitalOutput__ = 2;
const uint SOURCESELECTED__DigitalOutput__ = 3;
const uint GOTOSOURCECONTROLPAGE__DigitalOutput__ = 27;
const uint SOURCEHIGHLIGHTOUT__AnalogSerialOutput__ = 0;
const uint SOURCESCROLLMAX__AnalogSerialOutput__ = 1;
const uint SINGLESOURCEICON__AnalogSerialOutput__ = 2;
const uint CURRENTSOURCEICON__AnalogSerialOutput__ = 3;
const uint SINGLESOURCE__AnalogSerialOutput__ = 4;
const uint SINGLESOURCENAME__AnalogSerialOutput__ = 5;
const uint CURRENTSOURCENAME__AnalogSerialOutput__ = 6;
const uint CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__ = 7;
const uint CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__ = 8;
const uint CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__ = 9;
const uint NAMEOUT__DOLLAR____AnalogSerialOutput__ = 10;
const uint SOURCEICONSOUT__AnalogSerialOutput__ = 34;

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
