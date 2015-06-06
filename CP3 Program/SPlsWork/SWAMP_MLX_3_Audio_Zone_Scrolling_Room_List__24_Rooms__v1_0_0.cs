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

namespace CrestronModule_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_0_0
{
    public class CrestronModuleClass_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalInput ONSOURCESHARINGPAGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ROOMDISABLED;
        Crestron.Logos.SplusObjects.AnalogInput SELECTEDROOM;
        Crestron.Logos.SplusObjects.AnalogInput SOURCESHAREEXCLUDEDROOM;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ROOMLINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCESHARELINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTPOSITION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ROOMSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ROOMICONSIN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ROOMNAMEIN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMLISTINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput SHIFTSOURCESHAREHIGHLIGHTTOTOP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ITEMSELECTEDFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LINECHECKEDFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ROOMSELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCESHAREHIGHLIGHTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMSCROLLMAX;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCESHARESCROLLMAX;
        Crestron.Logos.SplusObjects.StringOutput CURRENTROOM__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCESHAREROOMSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ROOMICONSOUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCESHAREICONSOUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOMNAMEOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCESHAREROOMNAMEOUT__DOLLAR__;
        ushort [] SOURCESHAREROOMMAP;
        private void REFRESHSOURCESHARINGPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort ROOMNUMBERFROMINDEX = 0;
            
            
            __context__.SourceCodeLine = 91;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SOURCESHARESCROLLMAX  .Value; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 93;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 95;
                    ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ I ] ) ; 
                    __context__.SourceCodeLine = 97;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 99;
                        SOURCESHAREROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ ROOMNUMBERFROMINDEX ]  ) ; 
                        __context__.SourceCodeLine = 101;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue == ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue != 0) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 103;
                            LINECHECKEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 104;
                            SOURCESHAREICONSOUT [ I]  .Value = (ushort) ( 3 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 108;
                            LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 109;
                            SOURCESHAREICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 114;
                        SOURCESHAREROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( "(Room Disabled)"  ) ; 
                        __context__.SourceCodeLine = 115;
                        LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 91;
                } 
            
            
            }
            
        private void GENERATESOURCESHAREROOMMAP (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort COUNTER = 0;
            
            
            __context__.SourceCodeLine = 127;
            COUNTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 128;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMSCROLLMAX  .Value > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 130;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)ROOMSCROLLMAX  .Value; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 132;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != SELECTEDROOM  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != SOURCESHAREEXCLUDEDROOM  .UshortValue) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 134;
                        COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                        __context__.SourceCodeLine = 135;
                        SOURCESHAREROOMMAP [ COUNTER] = (ushort) ( LISTPOSITION[ I ] .UshortValue ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 130;
                    } 
                
                __context__.SourceCodeLine = 139;
                SOURCESHARESCROLLMAX  .Value = (ushort) ( COUNTER ) ; 
                __context__.SourceCodeLine = 141;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SOURCESHARESCROLLMAX  .Value < 24 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 143;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( (SOURCESHARESCROLLMAX  .Value + 1) ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)24; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 145;
                        SOURCESHAREROOMMAP [ I] = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 143;
                        } 
                    
                    } 
                
                } 
            
            
            }
            
        object SYSTEMINITIALIZED_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                ushort TEMPSCROLLMAX = 0;
                
                
                __context__.SourceCodeLine = 157;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 24 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 159;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 161;
                        TEMPSCROLLMAX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 162;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 157;
                    } 
                
                __context__.SourceCodeLine = 166;
                ROOMSCROLLMAX  .Value = (ushort) ( TEMPSCROLLMAX ) ; 
                __context__.SourceCodeLine = 168;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)ROOMSCROLLMAX  .Value; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 170;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ LISTPOSITION[ I ] .UshortValue ] .Value == 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 172;
                        ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ LISTPOSITION[ I ] .UshortValue ]  ) ; 
                        __context__.SourceCodeLine = 173;
                        ROOMICONSOUT [ I]  .Value = (ushort) ( ROOMICONSIN[ LISTPOSITION[ I ] .UshortValue ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 175;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != SELECTEDROOM  .UshortValue))  ) ) 
                            {
                            __context__.SourceCodeLine = 176;
                            ITEMSELECTEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 178;
                            ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 182;
                        ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( "(Room Disabled)"  ) ; 
                        __context__.SourceCodeLine = 183;
                        ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 184;
                        ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 168;
                    } 
                
                __context__.SourceCodeLine = 188;
                GENERATESOURCESHAREROOMMAP (  __context__  ) ; 
                __context__.SourceCodeLine = 190;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SELECTEDROOM  .UshortValue > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 192;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ SELECTEDROOM  .UshortValue ] .Value == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 193;
                        CURRENTROOM__DOLLAR__  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ SELECTEDROOM  .UshortValue ]  ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 196;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 198;
                    REFRESHSOURCESHARINGPAGE (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 201;
                ROOMLISTINITIALIZED  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SELECTEDROOM_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 209;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 211;
                GENERATESOURCESHAREROOMMAP (  __context__  ) ; 
                __context__.SourceCodeLine = 213;
                SOURCESHAREHIGHLIGHTOUT  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 214;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 216;
                SHIFTSOURCESHAREHIGHLIGHTTOTOP  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 217;
                SHIFTSOURCESHAREHIGHLIGHTTOTOP  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 219;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 221;
                    REFRESHSOURCESHARINGPAGE (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 224;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)24; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 226;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue == SELECTEDROOM  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ SELECTEDROOM  .UshortValue ] .Value == 0) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 227;
                        ITEMSELECTEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 229;
                        ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 224;
                    } 
                
                __context__.SourceCodeLine = 232;
                CURRENTROOM__DOLLAR__  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ SELECTEDROOM  .UshortValue ]  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ROOMLINESELECTED_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        ushort ROOMNUMBERFROMHIGHLIGHT = 0;
        
        
        __context__.SourceCodeLine = 242;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 244;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 246;
            ROOMNUMBERFROMHIGHLIGHT = (ushort) ( LISTPOSITION[ SELECTEDLINE ] .UshortValue ) ; 
            __context__.SourceCodeLine = 248;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMNUMBERFROMHIGHLIGHT != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMHIGHLIGHT ] .Value == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 250;
                ROOMSELECTED [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 251;
                ROOMSELECTED [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCESHARELINESELECTED_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        ushort ROOMNUMBERFROMHIGHLIGHT = 0;
        
        
        __context__.SourceCodeLine = 262;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 264;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 266;
            ROOMNUMBERFROMHIGHLIGHT = (ushort) ( SOURCESHAREROOMMAP[ SELECTEDLINE ] ) ; 
            __context__.SourceCodeLine = 268;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMNUMBERFROMHIGHLIGHT != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMHIGHLIGHT ] .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 270;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMHIGHLIGHT ] .UshortValue == ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue))  ) ) 
                    {
                    __context__.SourceCodeLine = 271;
                    SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 273;
                    SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue ) ; 
                    }
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMSOURCE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 281;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 282;
            REFRESHSOURCESHARINGPAGE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONSOURCESHARINGPAGE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 288;
        REFRESHSOURCESHARINGPAGE (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 296;
        ROOMSCROLLMAX  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 297;
        SOURCESHARESCROLLMAX  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 299;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)24; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 301;
            ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 299;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SOURCESHAREROOMMAP  = new ushort[ 25 ];
    
    SYSTEMINITIALIZED = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMINITIALIZED__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEMINITIALIZED__DigitalInput__, SYSTEMINITIALIZED );
    
    ONSOURCESHARINGPAGE = new Crestron.Logos.SplusObjects.DigitalInput( ONSOURCESHARINGPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ONSOURCESHARINGPAGE__DigitalInput__, ONSOURCESHARINGPAGE );
    
    ROOMDISABLED = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMDISABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ROOMDISABLED__DigitalInput__ + i, ROOMDISABLED__DigitalInput__, this );
        m_DigitalInputList.Add( ROOMDISABLED__DigitalInput__ + i, ROOMDISABLED[i+1] );
    }
    
    ROOMLINESELECTED = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ROOMLINESELECTED__DigitalInput__ + i, ROOMLINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( ROOMLINESELECTED__DigitalInput__ + i, ROOMLINESELECTED[i+1] );
    }
    
    SOURCESHARELINESELECTED = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESHARELINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCESHARELINESELECTED__DigitalInput__ + i, SOURCESHARELINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCESHARELINESELECTED__DigitalInput__ + i, SOURCESHARELINESELECTED[i+1] );
    }
    
    ROOMLISTINITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMLISTINITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMLISTINITIALIZED__DigitalOutput__, ROOMLISTINITIALIZED );
    
    SHIFTSOURCESHAREHIGHLIGHTTOTOP = new Crestron.Logos.SplusObjects.DigitalOutput( SHIFTSOURCESHAREHIGHLIGHTTOTOP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHIFTSOURCESHAREHIGHLIGHTTOTOP__DigitalOutput__, SHIFTSOURCESHAREHIGHLIGHTTOTOP );
    
    ITEMSELECTEDFB = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ITEMSELECTEDFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ITEMSELECTEDFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ITEMSELECTEDFB__DigitalOutput__ + i, ITEMSELECTEDFB[i+1] );
    }
    
    LINECHECKEDFB = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        LINECHECKEDFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LINECHECKEDFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LINECHECKEDFB__DigitalOutput__ + i, LINECHECKEDFB[i+1] );
    }
    
    ROOMSELECTED = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMSELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ROOMSELECTED__DigitalOutput__ + i, ROOMSELECTED[i+1] );
    }
    
    SELECTEDROOM = new Crestron.Logos.SplusObjects.AnalogInput( SELECTEDROOM__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTEDROOM__AnalogSerialInput__, SELECTEDROOM );
    
    SOURCESHAREEXCLUDEDROOM = new Crestron.Logos.SplusObjects.AnalogInput( SOURCESHAREEXCLUDEDROOM__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCESHAREEXCLUDEDROOM__AnalogSerialInput__, SOURCESHAREEXCLUDEDROOM );
    
    LISTPOSITION = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        LISTPOSITION[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LISTPOSITION__AnalogSerialInput__ + i, LISTPOSITION[i+1] );
    }
    
    ROOMSOURCE = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMSOURCE[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ROOMSOURCE__AnalogSerialInput__ + i, ROOMSOURCE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ROOMSOURCE__AnalogSerialInput__ + i, ROOMSOURCE[i+1] );
    }
    
    ROOMICONSIN = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMICONSIN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ROOMICONSIN__AnalogSerialInput__ + i, ROOMICONSIN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ROOMICONSIN__AnalogSerialInput__ + i, ROOMICONSIN[i+1] );
    }
    
    SOURCESHAREHIGHLIGHTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESHAREHIGHLIGHTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCESHAREHIGHLIGHTOUT__AnalogSerialOutput__, SOURCESHAREHIGHLIGHTOUT );
    
    ROOMSCROLLMAX = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMSCROLLMAX__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMSCROLLMAX__AnalogSerialOutput__, ROOMSCROLLMAX );
    
    SOURCESHARESCROLLMAX = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESHARESCROLLMAX__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCESHARESCROLLMAX__AnalogSerialOutput__, SOURCESHARESCROLLMAX );
    
    SOURCESHAREROOMSOURCE = new InOutArray<AnalogOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESHAREROOMSOURCE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESHAREROOMSOURCE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCESHAREROOMSOURCE__AnalogSerialOutput__ + i, SOURCESHAREROOMSOURCE[i+1] );
    }
    
    ROOMICONSOUT = new InOutArray<AnalogOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ROOMICONSOUT__AnalogSerialOutput__ + i, ROOMICONSOUT[i+1] );
    }
    
    SOURCESHAREICONSOUT = new InOutArray<AnalogOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESHAREICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESHAREICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCESHAREICONSOUT__AnalogSerialOutput__ + i, SOURCESHAREICONSOUT[i+1] );
    }
    
    ROOMNAMEIN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMNAMEIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ROOMNAMEIN__DOLLAR____AnalogSerialInput__ + i, ROOMNAMEIN__DOLLAR____AnalogSerialInput__, 32, this );
        m_StringInputList.Add( ROOMNAMEIN__DOLLAR____AnalogSerialInput__ + i, ROOMNAMEIN__DOLLAR__[i+1] );
    }
    
    CURRENTROOM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENTROOM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTROOM__DOLLAR____AnalogSerialOutput__, CURRENTROOM__DOLLAR__ );
    
    ROOMNAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMNAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, ROOMNAMEOUT__DOLLAR__[i+1] );
    }
    
    SOURCESHAREROOMNAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESHAREROOMNAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCESHAREROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCESHAREROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, SOURCESHAREROOMNAMEOUT__DOLLAR__[i+1] );
    }
    
    
    SYSTEMINITIALIZED.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMINITIALIZED_OnPush_0, false ) );
    SELECTEDROOM.OnAnalogChange.Add( new InputChangeHandlerWrapper( SELECTEDROOM_OnChange_1, false ) );
    for( uint i = 0; i < 24; i++ )
        ROOMLINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMLINESELECTED_OnPush_2, false ) );
        
    for( uint i = 0; i < 24; i++ )
        SOURCESHARELINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCESHARELINESELECTED_OnPush_3, false ) );
        
    for( uint i = 0; i < 24; i++ )
        ROOMSOURCE[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOMSOURCE_OnChange_4, false ) );
        
    ONSOURCESHARINGPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ONSOURCESHARINGPAGE_OnPush_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SWAMP_MLX_3_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SYSTEMINITIALIZED__DigitalInput__ = 0;
const uint ONSOURCESHARINGPAGE__DigitalInput__ = 1;
const uint ROOMDISABLED__DigitalInput__ = 2;
const uint SELECTEDROOM__AnalogSerialInput__ = 0;
const uint SOURCESHAREEXCLUDEDROOM__AnalogSerialInput__ = 1;
const uint ROOMLINESELECTED__DigitalInput__ = 26;
const uint SOURCESHARELINESELECTED__DigitalInput__ = 50;
const uint LISTPOSITION__AnalogSerialInput__ = 2;
const uint ROOMSOURCE__AnalogSerialInput__ = 26;
const uint ROOMICONSIN__AnalogSerialInput__ = 50;
const uint ROOMNAMEIN__DOLLAR____AnalogSerialInput__ = 74;
const uint ROOMLISTINITIALIZED__DigitalOutput__ = 0;
const uint SHIFTSOURCESHAREHIGHLIGHTTOTOP__DigitalOutput__ = 1;
const uint ITEMSELECTEDFB__DigitalOutput__ = 2;
const uint LINECHECKEDFB__DigitalOutput__ = 26;
const uint ROOMSELECTED__DigitalOutput__ = 50;
const uint SOURCESHAREHIGHLIGHTOUT__AnalogSerialOutput__ = 0;
const uint ROOMSCROLLMAX__AnalogSerialOutput__ = 1;
const uint SOURCESHARESCROLLMAX__AnalogSerialOutput__ = 2;
const uint CURRENTROOM__DOLLAR____AnalogSerialOutput__ = 3;
const uint SOURCESHAREROOMSOURCE__AnalogSerialOutput__ = 4;
const uint ROOMICONSOUT__AnalogSerialOutput__ = 28;
const uint SOURCESHAREICONSOUT__AnalogSerialOutput__ = 52;
const uint ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ = 76;
const uint SOURCESHAREROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ = 100;

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
