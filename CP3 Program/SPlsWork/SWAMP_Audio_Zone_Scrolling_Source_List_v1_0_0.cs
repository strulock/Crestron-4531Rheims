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

namespace CrestronModule_SWAMP_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0
{
    public class CrestronModuleClass_SWAMP_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOMCONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLFIRST;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLAST;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLPREVIOUS;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLNEXT;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLINEUP;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLINEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLSELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ITEMSELECTED;
        Crestron.Logos.SplusObjects.AnalogInput SCROLLPAGESIZE;
        Crestron.Logos.SplusObjects.AnalogInput SOURCEACTIVEIN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTPOSITION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> SOURCEICONSIN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NAMEIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE1IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE2IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGTRANSPORTIN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSCROLLCONTROLS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SELECTFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> GOTOSOURCECONTROLPAGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SCROLLHIGHLIGHTFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SHOWLINE;
        Crestron.Logos.SplusObjects.AnalogOutput SCROLLBAR;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGLINE2;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSOURCENOWPLAYINGTRANSPORT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NAMEOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGLINE1OUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGLINE2OUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGTRANSPORTOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ACTIVEBUTTONMODE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> INACTIVEBUTTONMODE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCEICONSOUT;
        ushort INDEX = 0;
        ushort SCROLLMAX = 0;
        ushort WAITINGFORSOURCECONTROL = 0;
        ushort HIGHLIGHT = 0;
        private void CALCULATESCROLLBAR (  SplusExecutionContext __context__, ushort TOTAL , ushort INDEX ) 
            { 
            
            __context__.SourceCodeLine = 87;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 88;
                SCROLLBAR  .Value = (ushort) ( 65535 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 89;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + SCROLLPAGESIZE  .UshortValue) - 1) >= TOTAL ))  ) ) 
                    {
                    __context__.SourceCodeLine = 90;
                    SCROLLBAR  .Value = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 92;
                    SCROLLBAR  .Value = (ushort) ( Functions.ToInteger( -( ((65535 / (TOTAL - SCROLLPAGESIZE  .UshortValue)) * (INDEX - 1)) ) ) ) ; 
                    }
                
                }
            
            
            }
            
        private void REDRAWHIGHLIGHT (  SplusExecutionContext __context__, ushort INDEX , ushort HIGHLIGHT , ushort PAGESIZE ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 99;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)PAGESIZE; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 101;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (((INDEX + I) - 1) == HIGHLIGHT))  ) ) 
                    { 
                    __context__.SourceCodeLine = 103;
                    SCROLLHIGHLIGHTFB [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 104;
                    ACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 105;
                    INACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 109;
                    SCROLLHIGHLIGHTFB [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 110;
                    ACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 111;
                    INACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 99;
                } 
            
            
            }
            
        private void REFRESHPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 120;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 122;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 124;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 126;
                        NAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 127;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 128;
                        NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 129;
                        NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 130;
                        NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 134;
                        NAMEOUT__DOLLAR__ [ I]  .UpdateValue ( NAMEIN__DOLLAR__ [ LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ]  ) ; 
                        __context__.SourceCodeLine = 135;
                        SOURCEICONSOUT [ I]  .Value = (ushort) ( SOURCEICONSIN[ LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 137;
                        NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ]  ) ; 
                        __context__.SourceCodeLine = 138;
                        NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ]  ) ; 
                        __context__.SourceCodeLine = 139;
                        NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ]  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 142;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 144;
                        SELECTFB [ I]  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 148;
                        SELECTFB [ I]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 151;
                    SHOWLINE [ I]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 155;
                    NAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 156;
                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 157;
                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 158;
                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 159;
                    SELECTFB [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 160;
                    SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 162;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHOWSCROLLCONTROLS  .Value == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 163;
                        SHOWLINE [ I]  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 165;
                        SHOWLINE [ I]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 120;
                } 
            
            __context__.SourceCodeLine = 169;
            CALCULATESCROLLBAR (  __context__ , (ushort)( SCROLLMAX ), (ushort)( INDEX )) ; 
            
            }
            
        object ROOMCONNECTED_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 176;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 24 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 178;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 180;
                        SCROLLMAX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 181;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 176;
                    } 
                
                __context__.SourceCodeLine = 185;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCROLLMAX == 1) ) || Functions.TestForTrue ( Functions.BoolToInt ( SCROLLMAX <= SCROLLPAGESIZE  .UshortValue ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 186;
                    SHOWSCROLLCONTROLS  .Value = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 188;
                    SHOWSCROLLCONTROLS  .Value = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 190;
                INDEX = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 191;
                HIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 192;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 193;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SCROLLFIRST_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 198;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 200;
                INDEX = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 201;
                HIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 202;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 203;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SCROLLLAST_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            INDEX = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 212;
            HIGHLIGHT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 214;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLMAX > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 216;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( SCROLLMAX , SCROLLPAGESIZE  .UshortValue ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 217;
                    INDEX = (ushort) ( ((SCROLLMAX + 1) - SCROLLPAGESIZE  .UshortValue) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 219;
                    INDEX = (ushort) ( ((SCROLLMAX + 1) - Mod( SCROLLMAX , SCROLLPAGESIZE  .UshortValue )) ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 222;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLMAX > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 224;
                HIGHLIGHT = (ushort) ( SCROLLMAX ) ; 
                } 
            
            __context__.SourceCodeLine = 227;
            REFRESHPAGE (  __context__  ) ; 
            __context__.SourceCodeLine = 228;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLNEXT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 235;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 237;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (INDEX + SCROLLPAGESIZE  .UshortValue) <= SCROLLMAX ))  ) ) 
                { 
                __context__.SourceCodeLine = 239;
                INDEX = (ushort) ( (INDEX + SCROLLPAGESIZE  .UshortValue) ) ; 
                __context__.SourceCodeLine = 240;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (HIGHLIGHT + SCROLLPAGESIZE  .UshortValue) <= SCROLLMAX ))  ) ) 
                    {
                    __context__.SourceCodeLine = 241;
                    HIGHLIGHT = (ushort) ( (HIGHLIGHT + SCROLLPAGESIZE  .UshortValue) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 243;
                    HIGHLIGHT = (ushort) ( SCROLLMAX ) ; 
                    }
                
                __context__.SourceCodeLine = 244;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 245;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLPREVIOUS_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 252;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 254;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX > SCROLLPAGESIZE  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 256;
                INDEX = (ushort) ( (INDEX - SCROLLPAGESIZE  .UshortValue) ) ; 
                __context__.SourceCodeLine = 257;
                HIGHLIGHT = (ushort) ( (HIGHLIGHT - SCROLLPAGESIZE  .UshortValue) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 259;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 261;
                    INDEX = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 262;
                    HIGHLIGHT = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 264;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            __context__.SourceCodeLine = 265;
            REFRESHPAGE (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLLINEUP_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 271;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 273;
            HIGHLIGHT = (ushort) ( (HIGHLIGHT - 1) ) ; 
            __context__.SourceCodeLine = 274;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT < INDEX ))  ) ) 
                { 
                __context__.SourceCodeLine = 276;
                INDEX = (ushort) ( HIGHLIGHT ) ; 
                __context__.SourceCodeLine = 277;
                REFRESHPAGE (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 279;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLLINEDOWN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 285;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT < SCROLLMAX ))  ) ) 
            { 
            __context__.SourceCodeLine = 287;
            HIGHLIGHT = (ushort) ( (HIGHLIGHT + 1) ) ; 
            __context__.SourceCodeLine = 288;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT > ((INDEX + SCROLLPAGESIZE  .UshortValue) - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 290;
                INDEX = (ushort) ( (INDEX + 1) ) ; 
                __context__.SourceCodeLine = 291;
                REFRESHPAGE (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 293;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLSELECT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 299;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 301;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( HIGHLIGHT <= SCROLLMAX ) ) && Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ HIGHLIGHT ] .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 303;
                SOURCESELECTED [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 304;
                SOURCESELECTED [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 306;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 307;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ITEMSELECTED_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        
        __context__.SourceCodeLine = 316;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 318;
            ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 319;
            ITEMINDEX = (ushort) ( ((ITEMINDEX + INDEX) - 1) ) ; 
            __context__.SourceCodeLine = 320;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ITEMINDEX <= SCROLLMAX ) ) && Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ ITEMINDEX ] .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 322;
                SOURCESELECTED [ LISTPOSITION[ ITEMINDEX ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 323;
                SOURCESELECTED [ LISTPOSITION[ ITEMINDEX ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 325;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ ITEMINDEX ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 326;
                GOTOSOURCECONTROLPAGE [ LISTPOSITION[ ITEMINDEX ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCEACTIVEIN_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 336;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 338;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 340;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 342;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 343;
                        SELECTFB [ I]  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 345;
                        SELECTFB [ I]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 348;
                    SELECTFB [ I]  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 338;
                } 
            
            } 
        
        __context__.SourceCodeLine = 352;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 354;
            CURRENTSOURCENAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 355;
            CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 356;
            CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 357;
            CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( ""  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 361;
            CURRENTSOURCENAME  .UpdateValue ( NAMEIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 362;
            CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 363;
            CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            __context__.SourceCodeLine = 364;
            CURRENTSOURCENOWPLAYINGTRANSPORT  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE1IN__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 373;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 374;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 376;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ))  ) ) 
                { 
                __context__.SourceCodeLine = 378;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 380;
                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 374;
            } 
        
        __context__.SourceCodeLine = 385;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 387;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMINDEX == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 389;
                CURRENTSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE2IN__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 400;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 401;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 403;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ))  ) ) 
                { 
                __context__.SourceCodeLine = 405;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 407;
                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 401;
            } 
        
        __context__.SourceCodeLine = 412;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 414;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMINDEX == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 416;
                CURRENTSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ SOURCEACTIVEIN  .UshortValue ]  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 426;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 427;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 429;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ))  ) ) 
                { 
                __context__.SourceCodeLine = 431;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue))  ) ) 
                    { 
                    __context__.SourceCodeLine = 433;
                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 427;
            } 
        
        __context__.SourceCodeLine = 438;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMCONNECTED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 440;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCEACTIVEIN  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ITEMINDEX == SOURCEACTIVEIN  .UshortValue) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 442;
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
        
        __context__.SourceCodeLine = 451;
        SCROLLMAX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 452;
        INDEX = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 453;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)5; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 455;
            SOURCEICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 456;
            SHOWLINE [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 453;
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
    
    SCROLLFIRST = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLFIRST__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLFIRST__DigitalInput__, SCROLLFIRST );
    
    SCROLLLAST = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLLAST__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLLAST__DigitalInput__, SCROLLLAST );
    
    SCROLLPREVIOUS = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLPREVIOUS__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLPREVIOUS__DigitalInput__, SCROLLPREVIOUS );
    
    SCROLLNEXT = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLNEXT__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLNEXT__DigitalInput__, SCROLLNEXT );
    
    SCROLLLINEUP = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLLINEUP__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLLINEUP__DigitalInput__, SCROLLLINEUP );
    
    SCROLLLINEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLLINEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLLINEDOWN__DigitalInput__, SCROLLLINEDOWN );
    
    SCROLLSELECT = new Crestron.Logos.SplusObjects.DigitalInput( SCROLLSELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLLSELECT__DigitalInput__, SCROLLSELECT );
    
    ITEMSELECTED = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ITEMSELECTED__DigitalInput__ + i, ITEMSELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( ITEMSELECTED__DigitalInput__ + i, ITEMSELECTED[i+1] );
    }
    
    SHOWSCROLLCONTROLS = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSCROLLCONTROLS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSCROLLCONTROLS__DigitalOutput__, SHOWSCROLLCONTROLS );
    
    SELECTFB = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SELECTFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SELECTFB__DigitalOutput__ + i, SELECTFB[i+1] );
    }
    
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
    
    SCROLLHIGHLIGHTFB = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SCROLLHIGHLIGHTFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SCROLLHIGHLIGHTFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SCROLLHIGHLIGHTFB__DigitalOutput__ + i, SCROLLHIGHLIGHTFB[i+1] );
    }
    
    SHOWLINE = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SHOWLINE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWLINE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SHOWLINE__DigitalOutput__ + i, SHOWLINE[i+1] );
    }
    
    SCROLLPAGESIZE = new Crestron.Logos.SplusObjects.AnalogInput( SCROLLPAGESIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCROLLPAGESIZE__AnalogSerialInput__, SCROLLPAGESIZE );
    
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
    
    SCROLLBAR = new Crestron.Logos.SplusObjects.AnalogOutput( SCROLLBAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROLLBAR__AnalogSerialOutput__, SCROLLBAR );
    
    ACTIVEBUTTONMODE = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ACTIVEBUTTONMODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIVEBUTTONMODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ACTIVEBUTTONMODE__AnalogSerialOutput__ + i, ACTIVEBUTTONMODE[i+1] );
    }
    
    INACTIVEBUTTONMODE = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        INACTIVEBUTTONMODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( INACTIVEBUTTONMODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( INACTIVEBUTTONMODE__AnalogSerialOutput__ + i, INACTIVEBUTTONMODE[i+1] );
    }
    
    SOURCEICONSOUT = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
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
    
    CURRENTSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENAME__AnalogSerialOutput__, CURRENTSOURCENAME );
    
    CURRENTSOURCENOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGLINE1 );
    
    CURRENTSOURCENOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGLINE2 );
    
    CURRENTSOURCENOWPLAYINGTRANSPORT = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__, CURRENTSOURCENOWPLAYINGTRANSPORT );
    
    NAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        NAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NAMEOUT__DOLLAR____AnalogSerialOutput__ + i, NAMEOUT__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGLINE1OUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        NOWPLAYINGLINE1OUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGLINE1OUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NOWPLAYINGLINE1OUT__DOLLAR____AnalogSerialOutput__ + i, NOWPLAYINGLINE1OUT__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGLINE2OUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        NOWPLAYINGLINE2OUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGLINE2OUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NOWPLAYINGLINE2OUT__DOLLAR____AnalogSerialOutput__ + i, NOWPLAYINGLINE2OUT__DOLLAR__[i+1] );
    }
    
    NOWPLAYINGTRANSPORTOUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        NOWPLAYINGTRANSPORTOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYINGTRANSPORTOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NOWPLAYINGTRANSPORTOUT__DOLLAR____AnalogSerialOutput__ + i, NOWPLAYINGTRANSPORTOUT__DOLLAR__[i+1] );
    }
    
    
    ROOMCONNECTED.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOMCONNECTED_OnChange_0, false ) );
    SCROLLFIRST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLFIRST_OnPush_1, false ) );
    SCROLLLAST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLAST_OnPush_2, false ) );
    SCROLLNEXT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLNEXT_OnPush_3, false ) );
    SCROLLPREVIOUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLPREVIOUS_OnPush_4, false ) );
    SCROLLLINEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLINEUP_OnPush_5, false ) );
    SCROLLLINEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLINEDOWN_OnPush_6, false ) );
    SCROLLSELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLSELECT_OnPush_7, false ) );
    for( uint i = 0; i < 5; i++ )
        ITEMSELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ITEMSELECTED_OnPush_8, false ) );
        
    SOURCEACTIVEIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCEACTIVEIN_OnChange_9, false ) );
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE1IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE1IN__DOLLAR___OnChange_10, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE2IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE2IN__DOLLAR___OnChange_11, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGTRANSPORTIN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_12, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SWAMP_AUDIO_ZONE_SCROLLING_SOURCE_LIST_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOMCONNECTED__DigitalInput__ = 0;
const uint SCROLLFIRST__DigitalInput__ = 1;
const uint SCROLLLAST__DigitalInput__ = 2;
const uint SCROLLPREVIOUS__DigitalInput__ = 3;
const uint SCROLLNEXT__DigitalInput__ = 4;
const uint SCROLLLINEUP__DigitalInput__ = 5;
const uint SCROLLLINEDOWN__DigitalInput__ = 6;
const uint SCROLLSELECT__DigitalInput__ = 7;
const uint ITEMSELECTED__DigitalInput__ = 8;
const uint SCROLLPAGESIZE__AnalogSerialInput__ = 0;
const uint SOURCEACTIVEIN__AnalogSerialInput__ = 1;
const uint LISTPOSITION__AnalogSerialInput__ = 2;
const uint SOURCEICONSIN__AnalogSerialInput__ = 26;
const uint NAMEIN__DOLLAR____AnalogSerialInput__ = 50;
const uint NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__ = 74;
const uint NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__ = 98;
const uint NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__ = 122;
const uint SHOWSCROLLCONTROLS__DigitalOutput__ = 0;
const uint SELECTFB__DigitalOutput__ = 1;
const uint SOURCESELECTED__DigitalOutput__ = 6;
const uint GOTOSOURCECONTROLPAGE__DigitalOutput__ = 30;
const uint SCROLLHIGHLIGHTFB__DigitalOutput__ = 54;
const uint SHOWLINE__DigitalOutput__ = 59;
const uint SCROLLBAR__AnalogSerialOutput__ = 0;
const uint CURRENTSOURCENAME__AnalogSerialOutput__ = 1;
const uint CURRENTSOURCENOWPLAYINGLINE1__AnalogSerialOutput__ = 2;
const uint CURRENTSOURCENOWPLAYINGLINE2__AnalogSerialOutput__ = 3;
const uint CURRENTSOURCENOWPLAYINGTRANSPORT__AnalogSerialOutput__ = 4;
const uint NAMEOUT__DOLLAR____AnalogSerialOutput__ = 5;
const uint NOWPLAYINGLINE1OUT__DOLLAR____AnalogSerialOutput__ = 10;
const uint NOWPLAYINGLINE2OUT__DOLLAR____AnalogSerialOutput__ = 15;
const uint NOWPLAYINGTRANSPORTOUT__DOLLAR____AnalogSerialOutput__ = 20;
const uint ACTIVEBUTTONMODE__AnalogSerialOutput__ = 25;
const uint INACTIVEBUTTONMODE__AnalogSerialOutput__ = 30;
const uint SOURCEICONSOUT__AnalogSerialOutput__ = 35;

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
