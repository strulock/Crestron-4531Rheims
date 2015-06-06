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

namespace CrestronModule_SWAMP_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_1_0
{
    public class CrestronModuleClass_SWAMP_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLFIRST;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLAST;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLPREVIOUS;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLNEXT;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLINEUP;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLLINEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput SCROLLSELECT;
        Crestron.Logos.SplusObjects.DigitalInput PREVENTSCROLLSELECT;
        Crestron.Logos.SplusObjects.DigitalInput ONROOMSELECTPAGE;
        Crestron.Logos.SplusObjects.DigitalInput ONSOURCESHARINGPAGE;
        Crestron.Logos.SplusObjects.DigitalInput COMBINEROOMANDSOURCENAMES;
        Crestron.Logos.SplusObjects.DigitalInput SOURCESHAREALL;
        Crestron.Logos.SplusObjects.DigitalInput OMNIVOLUMEACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput HIGHLIGHTEDVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput HIGHLIGHTEDVOLUMEDOWN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ITEMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ROOMDISABLED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ROOMFIXEDMODEON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LINEVOLUMEUP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LINEVOLUMEDOWN;
        Crestron.Logos.SplusObjects.AnalogInput SCROLLPAGESIZE;
        Crestron.Logos.SplusObjects.AnalogInput SELECTEDROOM;
        Crestron.Logos.SplusObjects.AnalogInput SOURCESHAREEXCLUDEDROOM;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTPOSITION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ROOMSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ROOMICONSIN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ROOMVOLUMEFB;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ROOMNAMEIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SOURCENAMEIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE1IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGLINE2IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NOWPLAYINGTRANSPORTIN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSCROLLCONTROLS;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWSECONDARYSUBPAGES;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ITEMSELECTEDFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LINECHECKEDFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ROOMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SCROLLHIGHLIGHTFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SHOWLINE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LINEVALID;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SHOWLINEOMNIVOLUME;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OMNIVOLUMEUP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OMNIVOLUMEDOWN;
        Crestron.Logos.SplusObjects.AnalogOutput SCROLLBAR;
        Crestron.Logos.SplusObjects.StringOutput CURRENTROOM__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCESHAREROOMSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ACTIVEBUTTONMODE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> INACTIVEBUTTONMODE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ROOMICONSOUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> LINEVOLUMEFB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOMNAMEOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCENAMEOUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGLINE1OUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGLINE2OUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NOWPLAYINGTRANSPORTOUT__DOLLAR__;
        ushort INDEX = 0;
        ushort ROOMINDEX = 0;
        ushort SOURCESHAREINDEX = 0;
        ushort SCROLLMAX = 0;
        ushort ROOMSCROLLMAX = 0;
        ushort SOURCESHARESCROLLMAX = 0;
        ushort HIGHLIGHT = 0;
        ushort ROOMHIGHLIGHT = 0;
        ushort SOURCESHAREHIGHLIGHT = 0;
        ushort [] SOURCESHAREROOMMAP;
        private void CALCULATESCROLLBAR (  SplusExecutionContext __context__, ushort TOTAL , ushort INDEX ) 
            { 
            
            __context__.SourceCodeLine = 119;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX <= 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 120;
                SCROLLBAR  .Value = (ushort) ( 65535 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 121;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((INDEX + SCROLLPAGESIZE  .UshortValue) - 1) >= TOTAL ))  ) ) 
                    {
                    __context__.SourceCodeLine = 122;
                    SCROLLBAR  .Value = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 124;
                    SCROLLBAR  .Value = (ushort) ( Functions.ToInteger( -( ((65535 / (TOTAL - SCROLLPAGESIZE  .UshortValue)) * (INDEX - 1)) ) ) ) ; 
                    }
                
                }
            
            
            }
            
        private void REDRAWHIGHLIGHT (  SplusExecutionContext __context__, ushort INDEX , ushort HIGHLIGHT , ushort PAGESIZE ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 131;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)PAGESIZE; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 133;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (((INDEX + I) - 1) == HIGHLIGHT))  ) ) 
                    { 
                    __context__.SourceCodeLine = 135;
                    SCROLLHIGHLIGHTFB [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 136;
                    ACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 137;
                    INACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 141;
                    SCROLLHIGHLIGHTFB [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 142;
                    ACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 143;
                    INACTIVEBUTTONMODE [ I]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 131;
                } 
            
            
            }
            
        private void REFRESHPAGE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort LISTINDEX = 0;
            
            ushort ROOMNUMBERFROMINDEX = 0;
            
            
            __context__.SourceCodeLine = 154;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 156;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 158;
                    LISTINDEX = (ushort) ( ((INDEX + I) - 1) ) ; 
                    __context__.SourceCodeLine = 160;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LISTINDEX <= SCROLLMAX ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 162;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 164;
                            ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ LISTINDEX ] ) ; 
                            __context__.SourceCodeLine = 166;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 168;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue == ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue != 0) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 169;
                                    LINECHECKEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 171;
                                    LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 174;
                                LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 178;
                            ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ LISTINDEX ] .UshortValue ) ; 
                            __context__.SourceCodeLine = 179;
                            LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 181;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 183;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 185;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 187;
                                        LINEVOLUMEFB [ I]  .Value = (ushort) ( ROOMVOLUMEFB[ ROOMNUMBERFROMINDEX ] .UshortValue ) ; 
                                        __context__.SourceCodeLine = 189;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMFIXEDMODEON[ ROOMNUMBERFROMINDEX ] .Value == 0) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 190;
                                            SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 1 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 192;
                                            SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                                            }
                                        
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 196;
                                        LINEVOLUMEFB [ I]  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 197;
                                        SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 201;
                                    LINEVOLUMEFB [ I]  .Value = (ushort) ( 0 ) ; 
                                    }
                                
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 205;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 207;
                            ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( "(Room Disabled)"  ) ; 
                            __context__.SourceCodeLine = 208;
                            SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 209;
                            NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 210;
                            NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 211;
                            NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 212;
                            ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 216;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 218;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMBINEROOMANDSOURCENAMES  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue != 0) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 219;
                                    MakeString ( ROOMNAMEOUT__DOLLAR__ [ I] , "{0} ({1})", ROOMNAMEIN__DOLLAR__ [ ROOMNUMBERFROMINDEX ] , SOURCENAMEIN__DOLLAR__ [ ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ] ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 221;
                                    ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ ROOMNUMBERFROMINDEX ]  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 223;
                                ROOMICONSOUT [ I]  .Value = (ushort) ( ROOMICONSIN[ ROOMNUMBERFROMINDEX ] .UshortValue ) ; 
                                __context__.SourceCodeLine = 225;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue != 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 227;
                                    SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( SOURCENAMEIN__DOLLAR__ [ ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 229;
                                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 230;
                                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 231;
                                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ]  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 235;
                                    SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 237;
                                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 238;
                                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 239;
                                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 245;
                                ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( "(Room Disabled)"  ) ; 
                                __context__.SourceCodeLine = 246;
                                SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 247;
                                NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 248;
                                NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 249;
                                NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 250;
                                ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 256;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SELECTEDROOM  .UshortValue == ROOMNUMBERFROMINDEX) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 258;
                            ITEMSELECTEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 263;
                            ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 266;
                        LINEVALID [ I]  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 267;
                        SHOWLINE [ I]  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 272;
                        ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 273;
                        SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 274;
                        NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 275;
                        NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 276;
                        NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 277;
                        ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 278;
                        LINEVALID [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 279;
                        ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 281;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                            {
                            __context__.SourceCodeLine = 282;
                            LINECHECKEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 284;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHOWSCROLLCONTROLS  .Value == 1))  ) ) 
                            {
                            __context__.SourceCodeLine = 285;
                            SHOWLINE [ I]  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 287;
                            SHOWLINE [ I]  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 156;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 292;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 293;
            SHOWSECONDARYSUBPAGES  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 295;
            CALCULATESCROLLBAR (  __context__ , (ushort)( SCROLLMAX ), (ushort)( INDEX )) ; 
            
            }
            
        private void GENERATESOURCESHAREROOMMAP (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort COUNTER = 0;
            
            
            __context__.SourceCodeLine = 303;
            SOURCESHAREHIGHLIGHT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 305;
            COUNTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 306;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMSCROLLMAX > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 308;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)ROOMSCROLLMAX; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 310;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != SELECTEDROOM  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != SOURCESHAREEXCLUDEDROOM  .UshortValue) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 312;
                        COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                        __context__.SourceCodeLine = 313;
                        SOURCESHAREROOMMAP [ COUNTER] = (ushort) ( LISTPOSITION[ I ] .UshortValue ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 308;
                    } 
                
                __context__.SourceCodeLine = 317;
                SOURCESHARESCROLLMAX = (ushort) ( COUNTER ) ; 
                __context__.SourceCodeLine = 319;
                SOURCESHAREHIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 321;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( (SOURCESHARESCROLLMAX + 1) ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)24; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 323;
                    SOURCESHAREROOMMAP [ I] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 321;
                    } 
                
                } 
            
            
            }
            
        private void HALTLINEVOLUMEADJUST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort ROOMNUMBERFROMINDEX = 0;
            
            
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 336;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 338;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 340;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 342;
                        OMNIVOLUMEUP [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 343;
                        OMNIVOLUMEDOWN [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 336;
                    } 
                
                } 
            
            
            }
            
        private void SAVEINDEXANDHIGHLIGHT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 351;
            if ( Functions.TestForTrue  ( ( ONROOMSELECTPAGE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 353;
                ROOMINDEX = (ushort) ( INDEX ) ; 
                __context__.SourceCodeLine = 354;
                ROOMHIGHLIGHT = (ushort) ( HIGHLIGHT ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 356;
                if ( Functions.TestForTrue  ( ( ONSOURCESHARINGPAGE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 358;
                    SOURCESHAREINDEX = (ushort) ( INDEX ) ; 
                    __context__.SourceCodeLine = 359;
                    SOURCESHAREHIGHLIGHT = (ushort) ( HIGHLIGHT ) ; 
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
                
                
                __context__.SourceCodeLine = 368;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 24 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 370;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTPOSITION[ I ] .UshortValue != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 372;
                        ROOMSCROLLMAX = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 373;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 368;
                    } 
                
                __context__.SourceCodeLine = 377;
                SCROLLMAX = (ushort) ( ROOMSCROLLMAX ) ; 
                __context__.SourceCodeLine = 379;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCROLLMAX == 1) ) || Functions.TestForTrue ( Functions.BoolToInt ( SCROLLMAX <= SCROLLPAGESIZE  .UshortValue ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 380;
                    SHOWSCROLLCONTROLS  .Value = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 382;
                    SHOWSCROLLCONTROLS  .Value = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 384;
                INDEX = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 385;
                ROOMHIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 387;
                GENERATESOURCESHAREROOMMAP (  __context__  ) ; 
                __context__.SourceCodeLine = 388;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SELECTEDROOM  .UshortValue > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 390;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ SELECTEDROOM  .UshortValue ] .Value == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 391;
                        CURRENTROOM__DOLLAR__  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ SELECTEDROOM  .UshortValue ]  ) ; 
                        }
                    
                    } 
                
                
                
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
            
            __context__.SourceCodeLine = 397;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 399;
                HALTLINEVOLUMEADJUST (  __context__  ) ; 
                __context__.SourceCodeLine = 401;
                INDEX = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 402;
                HIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 403;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 404;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                __context__.SourceCodeLine = 405;
                SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 411;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 413;
            HALTLINEVOLUMEADJUST (  __context__  ) ; 
            __context__.SourceCodeLine = 415;
            INDEX = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 416;
            HIGHLIGHT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 418;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLMAX > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 420;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( SCROLLMAX , SCROLLPAGESIZE  .UshortValue ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 421;
                    INDEX = (ushort) ( ((SCROLLMAX + 1) - SCROLLPAGESIZE  .UshortValue) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 423;
                    INDEX = (ushort) ( (SCROLLMAX - Mod( SCROLLMAX , SCROLLPAGESIZE  .UshortValue )) ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 426;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLMAX > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 428;
                HIGHLIGHT = (ushort) ( SCROLLMAX ) ; 
                } 
            
            __context__.SourceCodeLine = 431;
            REFRESHPAGE (  __context__  ) ; 
            __context__.SourceCodeLine = 432;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            __context__.SourceCodeLine = 433;
            SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 439;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 441;
            HALTLINEVOLUMEADJUST (  __context__  ) ; 
            __context__.SourceCodeLine = 443;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (INDEX + SCROLLPAGESIZE  .UshortValue) <= SCROLLMAX ))  ) ) 
                { 
                __context__.SourceCodeLine = 445;
                INDEX = (ushort) ( (INDEX + SCROLLPAGESIZE  .UshortValue) ) ; 
                __context__.SourceCodeLine = 446;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (HIGHLIGHT + SCROLLPAGESIZE  .UshortValue) <= SCROLLMAX ))  ) ) 
                    {
                    __context__.SourceCodeLine = 447;
                    HIGHLIGHT = (ushort) ( (HIGHLIGHT + SCROLLPAGESIZE  .UshortValue) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 449;
                    HIGHLIGHT = (ushort) ( SCROLLMAX ) ; 
                    }
                
                __context__.SourceCodeLine = 451;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 452;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                __context__.SourceCodeLine = 453;
                SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 460;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 462;
            HALTLINEVOLUMEADJUST (  __context__  ) ; 
            __context__.SourceCodeLine = 464;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX > SCROLLPAGESIZE  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 466;
                INDEX = (ushort) ( (INDEX - SCROLLPAGESIZE  .UshortValue) ) ; 
                __context__.SourceCodeLine = 467;
                HIGHLIGHT = (ushort) ( (HIGHLIGHT - SCROLLPAGESIZE  .UshortValue) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 469;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 471;
                    INDEX = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 472;
                    HIGHLIGHT = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 475;
            REFRESHPAGE (  __context__  ) ; 
            __context__.SourceCodeLine = 476;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            __context__.SourceCodeLine = 477;
            SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 483;
        HALTLINEVOLUMEADJUST (  __context__  ) ; 
        __context__.SourceCodeLine = 485;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 487;
            HIGHLIGHT = (ushort) ( (HIGHLIGHT - 1) ) ; 
            __context__.SourceCodeLine = 488;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT < INDEX ))  ) ) 
                { 
                __context__.SourceCodeLine = 490;
                INDEX = (ushort) ( HIGHLIGHT ) ; 
                __context__.SourceCodeLine = 491;
                REFRESHPAGE (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 494;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            __context__.SourceCodeLine = 495;
            SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 501;
        HALTLINEVOLUMEADJUST (  __context__  ) ; 
        __context__.SourceCodeLine = 503;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT < SCROLLMAX ))  ) ) 
            { 
            __context__.SourceCodeLine = 505;
            HIGHLIGHT = (ushort) ( (HIGHLIGHT + 1) ) ; 
            __context__.SourceCodeLine = 506;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HIGHLIGHT > ((INDEX + SCROLLPAGESIZE  .UshortValue) - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 508;
                INDEX = (ushort) ( (INDEX + 1) ) ; 
                __context__.SourceCodeLine = 509;
                REFRESHPAGE (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 512;
            REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
            __context__.SourceCodeLine = 513;
            SAVEINDEXANDHIGHLIGHT (  __context__  ) ; 
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
        ushort ROOMNUMBERFROMHIGHLIGHT = 0;
        
        
        __context__.SourceCodeLine = 521;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (PREVENTSCROLLSELECT  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 523;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 524;
                ROOMNUMBERFROMHIGHLIGHT = (ushort) ( SOURCESHAREROOMMAP[ HIGHLIGHT ] ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 526;
                ROOMNUMBERFROMHIGHLIGHT = (ushort) ( LISTPOSITION[ HIGHLIGHT ] .UshortValue ) ; 
                }
            
            __context__.SourceCodeLine = 528;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMHIGHLIGHT != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 530;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( HIGHLIGHT <= SCROLLMAX ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMHIGHLIGHT ] .Value == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 532;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 534;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 536;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMHIGHLIGHT ] .UshortValue == ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue))  ) ) 
                                {
                                __context__.SourceCodeLine = 537;
                                SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 539;
                                SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue ) ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 542;
                        REFRESHPAGE (  __context__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 546;
                        ROOMSELECTED [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 547;
                        ROOMSELECTED [ ROOMNUMBERFROMHIGHLIGHT]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
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
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 559;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 561;
            ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 562;
            ITEMINDEX = (ushort) ( ((ITEMINDEX + INDEX) - 1) ) ; 
            __context__.SourceCodeLine = 564;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 565;
                ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ ITEMINDEX ] ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 567;
                ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ITEMINDEX ] .UshortValue ) ; 
                }
            
            __context__.SourceCodeLine = 569;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 571;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( ITEMINDEX <= SCROLLMAX ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 573;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 575;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 577;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue == ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue))  ) ) 
                                {
                                __context__.SourceCodeLine = 578;
                                SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 580;
                                SOURCESHAREROOMSOURCE [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue ) ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 583;
                        REFRESHPAGE (  __context__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 587;
                        ROOMSELECTED [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 588;
                        ROOMSELECTED [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE1IN__DOLLAR___OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 601;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 603;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 605;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 607;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 608;
                    ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ ((INDEX + I) - 1) ] ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 610;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    }
                
                __context__.SourceCodeLine = 612;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 614;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 616;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 618;
                            NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 605;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGLINE2IN__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 632;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 634;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 636;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 638;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 639;
                    ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ ((INDEX + I) - 1) ] ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 641;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    }
                
                __context__.SourceCodeLine = 643;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 645;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 647;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 649;
                            NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 636;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ITEMINDEX = 0;
        
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 663;
        ITEMINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 665;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 667;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 669;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 670;
                    ROOMNUMBERFROMINDEX = (ushort) ( SOURCESHAREROOMMAP[ ((INDEX + I) - 1) ] ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 672;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    }
                
                __context__.SourceCodeLine = 674;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 676;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( ((INDEX + I) - 1) <= SCROLLMAX ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 678;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMINDEX == ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 680;
                            NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ ITEMINDEX ]  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 667;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMSOURCE_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ROOMWITHNEWSOURCE = 0;
        
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 694;
        ROOMWITHNEWSOURCE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 696;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 698;
            REFRESHPAGE (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 702;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 704;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 706;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 708;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 710;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 712;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMWITHNEWSOURCE == ROOMNUMBERFROMINDEX))  ) ) 
                                { 
                                __context__.SourceCodeLine = 714;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMSOURCE[ ROOMWITHNEWSOURCE ] .UshortValue > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 716;
                                    SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( SOURCENAMEIN__DOLLAR__ [ ROOMSOURCE[ ROOMWITHNEWSOURCE ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 717;
                                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE1IN__DOLLAR__ [ ROOMSOURCE[ ROOMWITHNEWSOURCE ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 718;
                                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGLINE2IN__DOLLAR__ [ ROOMSOURCE[ ROOMWITHNEWSOURCE ] .UshortValue ]  ) ; 
                                    __context__.SourceCodeLine = 719;
                                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( NOWPLAYINGTRANSPORTIN__DOLLAR__ [ ROOMSOURCE[ ROOMWITHNEWSOURCE ] .UshortValue ]  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 723;
                                    SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 724;
                                    NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 725;
                                    NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 726;
                                    NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 704;
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTEDROOM_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort LISTINDEX = 0;
        
        
        __context__.SourceCodeLine = 741;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 743;
            GENERATESOURCESHAREROOMMAP (  __context__  ) ; 
            __context__.SourceCodeLine = 745;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 747;
                INDEX = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 748;
                HIGHLIGHT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 749;
                SCROLLMAX = (ushort) ( SOURCESHARESCROLLMAX ) ; 
                __context__.SourceCodeLine = 750;
                SHOWSECONDARYSUBPAGES  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 751;
                REFRESHPAGE (  __context__  ) ; 
                __context__.SourceCodeLine = 752;
                REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 756;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ SELECTEDROOM  .UshortValue ] .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 758;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 760;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 762;
                            LISTINDEX = (ushort) ( ((INDEX + I) - 1) ) ; 
                            __context__.SourceCodeLine = 763;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LISTINDEX <= SCROLLMAX ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 765;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LISTPOSITION[ LISTINDEX ] .UshortValue == SELECTEDROOM  .UshortValue) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMDISABLED[ LISTPOSITION[ LISTINDEX ] .UshortValue ] .Value == 0) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 766;
                                    ITEMSELECTEDFB [ I]  .Value = (ushort) ( 1 ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 768;
                                    ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 760;
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 774;
            CURRENTROOM__DOLLAR__  .UpdateValue ( ROOMNAMEIN__DOLLAR__ [ SELECTEDROOM  .UshortValue ]  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONROOMSELECTPAGE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 782;
        SCROLLMAX = (ushort) ( ROOMSCROLLMAX ) ; 
        __context__.SourceCodeLine = 783;
        INDEX = (ushort) ( ROOMINDEX ) ; 
        __context__.SourceCodeLine = 784;
        HIGHLIGHT = (ushort) ( ROOMHIGHLIGHT ) ; 
        __context__.SourceCodeLine = 786;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCROLLMAX == 1) ) || Functions.TestForTrue ( Functions.BoolToInt ( SCROLLMAX <= SCROLLPAGESIZE  .UshortValue ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 787;
            SHOWSCROLLCONTROLS  .Value = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 789;
            SHOWSCROLLCONTROLS  .Value = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 791;
        SHOWSECONDARYSUBPAGES  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 793;
        REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
        __context__.SourceCodeLine = 794;
        REFRESHPAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONROOMSELECTPAGE_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 799;
        HALTLINEVOLUMEADJUST (  __context__  ) ; 
        __context__.SourceCodeLine = 800;
        SHOWSECONDARYSUBPAGES  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONSOURCESHARINGPAGE_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 807;
        SCROLLMAX = (ushort) ( SOURCESHARESCROLLMAX ) ; 
        __context__.SourceCodeLine = 808;
        INDEX = (ushort) ( SOURCESHAREINDEX ) ; 
        __context__.SourceCodeLine = 809;
        HIGHLIGHT = (ushort) ( SOURCESHAREHIGHLIGHT ) ; 
        __context__.SourceCodeLine = 811;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SCROLLMAX == 1) ) || Functions.TestForTrue ( Functions.BoolToInt ( SCROLLMAX <= SCROLLPAGESIZE  .UshortValue ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 812;
            SHOWSCROLLCONTROLS  .Value = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 814;
            SHOWSCROLLCONTROLS  .Value = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 817;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)5; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 819;
            ROOMNAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 820;
            SOURCENAMEOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 821;
            NOWPLAYINGLINE1OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 822;
            NOWPLAYINGLINE2OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 823;
            NOWPLAYINGTRANSPORTOUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 824;
            ITEMSELECTEDFB [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 817;
            } 
        
        __context__.SourceCodeLine = 827;
        SHOWSECONDARYSUBPAGES  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 829;
        REDRAWHIGHLIGHT (  __context__ , (ushort)( INDEX ), (ushort)( HIGHLIGHT ), (ushort)( SCROLLPAGESIZE  .UshortValue )) ; 
        __context__.SourceCodeLine = 830;
        REFRESHPAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCESHAREALL_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 837;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 839;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLMAX; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 841;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ SOURCESHAREROOMMAP[ I ] ] .Value == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 842;
                    SOURCESHAREROOMSOURCE [ SOURCESHAREROOMMAP[ I ]]  .Value = (ushort) ( ROOMSOURCE[ SELECTEDROOM  .UshortValue ] .UshortValue ) ; 
                    }
                
                __context__.SourceCodeLine = 839;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINEVOLUMEUP_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LASTMODIFIEDINDEX = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 852;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 854;
            LASTMODIFIEDINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 855;
            ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + LASTMODIFIEDINDEX) - 1) ] .UshortValue ) ; 
            __context__.SourceCodeLine = 857;
            OMNIVOLUMEUP [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINEVOLUMEUP_OnRelease_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LASTMODIFIEDINDEX = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 866;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 868;
            LASTMODIFIEDINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 869;
            ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + LASTMODIFIEDINDEX) - 1) ] .UshortValue ) ; 
            __context__.SourceCodeLine = 871;
            OMNIVOLUMEUP [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINEVOLUMEDOWN_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LASTMODIFIEDINDEX = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 880;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 882;
            LASTMODIFIEDINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 883;
            ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + LASTMODIFIEDINDEX) - 1) ] .UshortValue ) ; 
            __context__.SourceCodeLine = 885;
            OMNIVOLUMEDOWN [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LINEVOLUMEDOWN_OnRelease_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 893;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 895;
            ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + Functions.GetLastModifiedArrayIndex( __SignalEventArg__ )) - 1) ] .UshortValue ) ; 
            __context__.SourceCodeLine = 896;
            OMNIVOLUMEDOWN [ ROOMNUMBERFROMINDEX]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIGHLIGHTEDVOLUMEUP_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 902;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 903;
            OMNIVOLUMEUP [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIGHLIGHTEDVOLUMEUP_OnRelease_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 908;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 909;
            OMNIVOLUMEUP [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIGHLIGHTEDVOLUMEDOWN_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 915;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 916;
            OMNIVOLUMEDOWN [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIGHLIGHTEDVOLUMEDOWN_OnRelease_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 921;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SYSTEMINITIALIZED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ONROOMSELECTPAGE  .Value == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (OMNIVOLUMEACTIVE  .Value == 1) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 922;
            OMNIVOLUMEDOWN [ LISTPOSITION[ HIGHLIGHT ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OMNIVOLUMEACTIVE_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 931;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 933;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 935;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 937;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 939;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 941;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 943;
                            LINEVOLUMEFB [ I]  .Value = (ushort) ( ROOMVOLUMEFB[ ROOMNUMBERFROMINDEX ] .UshortValue ) ; 
                            __context__.SourceCodeLine = 945;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMFIXEDMODEON[ ROOMNUMBERFROMINDEX ] .Value == 0) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 946;
                                SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 948;
                                SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 952;
                            LINEVOLUMEFB [ I]  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 953;
                            SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 957;
                        LINEVOLUMEFB [ I]  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 935;
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMFIXEDMODEON_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 968;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ONSOURCESHARINGPAGE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 970;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 972;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 974;
                    ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 976;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ROOMNUMBERFROMINDEX > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 978;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMDISABLED[ ROOMNUMBERFROMINDEX ] .Value == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 980;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( 0 < ROOMSOURCE[ ROOMNUMBERFROMINDEX ] .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt (ROOMFIXEDMODEON[ ROOMNUMBERFROMINDEX ] .Value == 0) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 981;
                                SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 983;
                                SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 987;
                            SHOWLINEOMNIVOLUME [ I]  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 972;
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMVOLUMEFB_OnChange_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort MODIFIEDINDEX = 0;
        
        ushort ROOMNUMBERFROMINDEX = 0;
        
        
        __context__.SourceCodeLine = 1001;
        MODIFIEDINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 1003;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SCROLLPAGESIZE  .UshortValue > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1005;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)SCROLLPAGESIZE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1007;
                ROOMNUMBERFROMINDEX = (ushort) ( LISTPOSITION[ ((INDEX + I) - 1) ] .UshortValue ) ; 
                __context__.SourceCodeLine = 1009;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1011;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMNUMBERFROMINDEX == MODIFIEDINDEX))  ) ) 
                        {
                        __context__.SourceCodeLine = 1012;
                        LINEVOLUMEFB [ I]  .Value = (ushort) ( ROOMVOLUMEFB[ MODIFIEDINDEX ] .UshortValue ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 1005;
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
        
        __context__.SourceCodeLine = 1023;
        ROOMSCROLLMAX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1024;
        SOURCESHARESCROLLMAX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1025;
        SCROLLMAX = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1026;
        INDEX = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1027;
        SOURCESHAREINDEX = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1028;
        ROOMINDEX = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1030;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)5; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1032;
            ROOMICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1033;
            SHOWLINE [ I]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1030;
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
    
    PREVENTSCROLLSELECT = new Crestron.Logos.SplusObjects.DigitalInput( PREVENTSCROLLSELECT__DigitalInput__, this );
    m_DigitalInputList.Add( PREVENTSCROLLSELECT__DigitalInput__, PREVENTSCROLLSELECT );
    
    ONROOMSELECTPAGE = new Crestron.Logos.SplusObjects.DigitalInput( ONROOMSELECTPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ONROOMSELECTPAGE__DigitalInput__, ONROOMSELECTPAGE );
    
    ONSOURCESHARINGPAGE = new Crestron.Logos.SplusObjects.DigitalInput( ONSOURCESHARINGPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ONSOURCESHARINGPAGE__DigitalInput__, ONSOURCESHARINGPAGE );
    
    COMBINEROOMANDSOURCENAMES = new Crestron.Logos.SplusObjects.DigitalInput( COMBINEROOMANDSOURCENAMES__DigitalInput__, this );
    m_DigitalInputList.Add( COMBINEROOMANDSOURCENAMES__DigitalInput__, COMBINEROOMANDSOURCENAMES );
    
    SOURCESHAREALL = new Crestron.Logos.SplusObjects.DigitalInput( SOURCESHAREALL__DigitalInput__, this );
    m_DigitalInputList.Add( SOURCESHAREALL__DigitalInput__, SOURCESHAREALL );
    
    OMNIVOLUMEACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( OMNIVOLUMEACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( OMNIVOLUMEACTIVE__DigitalInput__, OMNIVOLUMEACTIVE );
    
    HIGHLIGHTEDVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( HIGHLIGHTEDVOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( HIGHLIGHTEDVOLUMEUP__DigitalInput__, HIGHLIGHTEDVOLUMEUP );
    
    HIGHLIGHTEDVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( HIGHLIGHTEDVOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HIGHLIGHTEDVOLUMEDOWN__DigitalInput__, HIGHLIGHTEDVOLUMEDOWN );
    
    ITEMSELECTED = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ITEMSELECTED__DigitalInput__ + i, ITEMSELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( ITEMSELECTED__DigitalInput__ + i, ITEMSELECTED[i+1] );
    }
    
    ROOMDISABLED = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMDISABLED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ROOMDISABLED__DigitalInput__ + i, ROOMDISABLED__DigitalInput__, this );
        m_DigitalInputList.Add( ROOMDISABLED__DigitalInput__ + i, ROOMDISABLED[i+1] );
    }
    
    ROOMFIXEDMODEON = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMFIXEDMODEON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ROOMFIXEDMODEON__DigitalInput__ + i, ROOMFIXEDMODEON__DigitalInput__, this );
        m_DigitalInputList.Add( ROOMFIXEDMODEON__DigitalInput__ + i, ROOMFIXEDMODEON[i+1] );
    }
    
    LINEVOLUMEUP = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        LINEVOLUMEUP[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LINEVOLUMEUP__DigitalInput__ + i, LINEVOLUMEUP__DigitalInput__, this );
        m_DigitalInputList.Add( LINEVOLUMEUP__DigitalInput__ + i, LINEVOLUMEUP[i+1] );
    }
    
    LINEVOLUMEDOWN = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        LINEVOLUMEDOWN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LINEVOLUMEDOWN__DigitalInput__ + i, LINEVOLUMEDOWN__DigitalInput__, this );
        m_DigitalInputList.Add( LINEVOLUMEDOWN__DigitalInput__ + i, LINEVOLUMEDOWN[i+1] );
    }
    
    SHOWSCROLLCONTROLS = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSCROLLCONTROLS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSCROLLCONTROLS__DigitalOutput__, SHOWSCROLLCONTROLS );
    
    SHOWSECONDARYSUBPAGES = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWSECONDARYSUBPAGES__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWSECONDARYSUBPAGES__DigitalOutput__, SHOWSECONDARYSUBPAGES );
    
    ITEMSELECTEDFB = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ITEMSELECTEDFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ITEMSELECTEDFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ITEMSELECTEDFB__DigitalOutput__ + i, ITEMSELECTEDFB[i+1] );
    }
    
    LINECHECKEDFB = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
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
    
    LINEVALID = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        LINEVALID[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LINEVALID__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LINEVALID__DigitalOutput__ + i, LINEVALID[i+1] );
    }
    
    SHOWLINEOMNIVOLUME = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SHOWLINEOMNIVOLUME[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWLINEOMNIVOLUME__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SHOWLINEOMNIVOLUME__DigitalOutput__ + i, SHOWLINEOMNIVOLUME[i+1] );
    }
    
    OMNIVOLUMEUP = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        OMNIVOLUMEUP[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OMNIVOLUMEUP__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OMNIVOLUMEUP__DigitalOutput__ + i, OMNIVOLUMEUP[i+1] );
    }
    
    OMNIVOLUMEDOWN = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        OMNIVOLUMEDOWN[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OMNIVOLUMEDOWN__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OMNIVOLUMEDOWN__DigitalOutput__ + i, OMNIVOLUMEDOWN[i+1] );
    }
    
    SCROLLPAGESIZE = new Crestron.Logos.SplusObjects.AnalogInput( SCROLLPAGESIZE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCROLLPAGESIZE__AnalogSerialInput__, SCROLLPAGESIZE );
    
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
    
    ROOMVOLUMEFB = new InOutArray<AnalogInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMVOLUMEFB[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ROOMVOLUMEFB__AnalogSerialInput__ + i, ROOMVOLUMEFB__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ROOMVOLUMEFB__AnalogSerialInput__ + i, ROOMVOLUMEFB[i+1] );
    }
    
    SCROLLBAR = new Crestron.Logos.SplusObjects.AnalogOutput( SCROLLBAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROLLBAR__AnalogSerialOutput__, SCROLLBAR );
    
    SOURCESHAREROOMSOURCE = new InOutArray<AnalogOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESHAREROOMSOURCE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCESHAREROOMSOURCE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCESHAREROOMSOURCE__AnalogSerialOutput__ + i, SOURCESHAREROOMSOURCE[i+1] );
    }
    
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
    
    ROOMICONSOUT = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ROOMICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ROOMICONSOUT__AnalogSerialOutput__ + i, ROOMICONSOUT[i+1] );
    }
    
    LINEVOLUMEFB = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        LINEVOLUMEFB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( LINEVOLUMEFB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( LINEVOLUMEFB__AnalogSerialOutput__ + i, LINEVOLUMEFB[i+1] );
    }
    
    ROOMNAMEIN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        ROOMNAMEIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ROOMNAMEIN__DOLLAR____AnalogSerialInput__ + i, ROOMNAMEIN__DOLLAR____AnalogSerialInput__, 32, this );
        m_StringInputList.Add( ROOMNAMEIN__DOLLAR____AnalogSerialInput__ + i, ROOMNAMEIN__DOLLAR__[i+1] );
    }
    
    SOURCENAMEIN__DOLLAR__ = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCENAMEIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( SOURCENAMEIN__DOLLAR____AnalogSerialInput__ + i, SOURCENAMEIN__DOLLAR____AnalogSerialInput__, 32, this );
        m_StringInputList.Add( SOURCENAMEIN__DOLLAR____AnalogSerialInput__ + i, SOURCENAMEIN__DOLLAR__[i+1] );
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
    
    CURRENTROOM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENTROOM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTROOM__DOLLAR____AnalogSerialOutput__, CURRENTROOM__DOLLAR__ );
    
    ROOMNAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ROOMNAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ + i, ROOMNAMEOUT__DOLLAR__[i+1] );
    }
    
    SOURCENAMEOUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SOURCENAMEOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCENAMEOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCENAMEOUT__DOLLAR____AnalogSerialOutput__ + i, SOURCENAMEOUT__DOLLAR__[i+1] );
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
    
    
    SYSTEMINITIALIZED.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMINITIALIZED_OnPush_0, false ) );
    SCROLLFIRST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLFIRST_OnPush_1, false ) );
    SCROLLLAST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLAST_OnPush_2, false ) );
    SCROLLNEXT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLNEXT_OnPush_3, false ) );
    SCROLLPREVIOUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLPREVIOUS_OnPush_4, false ) );
    SCROLLLINEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLINEUP_OnPush_5, false ) );
    SCROLLLINEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLLINEDOWN_OnPush_6, false ) );
    SCROLLSELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLLSELECT_OnPush_7, false ) );
    for( uint i = 0; i < 5; i++ )
        ITEMSELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ITEMSELECTED_OnPush_8, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE1IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE1IN__DOLLAR___OnChange_9, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGLINE2IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGLINE2IN__DOLLAR___OnChange_10, false ) );
        
    for( uint i = 0; i < 24; i++ )
        NOWPLAYINGTRANSPORTIN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NOWPLAYINGTRANSPORTIN__DOLLAR___OnChange_11, false ) );
        
    for( uint i = 0; i < 24; i++ )
        ROOMSOURCE[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOMSOURCE_OnChange_12, false ) );
        
    SELECTEDROOM.OnAnalogChange.Add( new InputChangeHandlerWrapper( SELECTEDROOM_OnChange_13, false ) );
    ONROOMSELECTPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ONROOMSELECTPAGE_OnPush_14, false ) );
    ONROOMSELECTPAGE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ONROOMSELECTPAGE_OnRelease_15, false ) );
    ONSOURCESHARINGPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ONSOURCESHARINGPAGE_OnPush_16, false ) );
    SOURCESHAREALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCESHAREALL_OnPush_17, false ) );
    for( uint i = 0; i < 5; i++ )
        LINEVOLUMEUP[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( LINEVOLUMEUP_OnPush_18, false ) );
        
    for( uint i = 0; i < 5; i++ )
        LINEVOLUMEUP[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( LINEVOLUMEUP_OnRelease_19, false ) );
        
    for( uint i = 0; i < 5; i++ )
        LINEVOLUMEDOWN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( LINEVOLUMEDOWN_OnPush_20, false ) );
        
    for( uint i = 0; i < 5; i++ )
        LINEVOLUMEDOWN[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( LINEVOLUMEDOWN_OnRelease_21, false ) );
        
    HIGHLIGHTEDVOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIGHLIGHTEDVOLUMEUP_OnPush_22, false ) );
    HIGHLIGHTEDVOLUMEUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( HIGHLIGHTEDVOLUMEUP_OnRelease_23, false ) );
    HIGHLIGHTEDVOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIGHLIGHTEDVOLUMEDOWN_OnPush_24, false ) );
    HIGHLIGHTEDVOLUMEDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( HIGHLIGHTEDVOLUMEDOWN_OnRelease_25, false ) );
    OMNIVOLUMEACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( OMNIVOLUMEACTIVE_OnPush_26, false ) );
    for( uint i = 0; i < 24; i++ )
        ROOMFIXEDMODEON[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOMFIXEDMODEON_OnChange_27, false ) );
        
    for( uint i = 0; i < 24; i++ )
        ROOMVOLUMEFB[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOMVOLUMEFB_OnChange_28, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SWAMP_AUDIO_ZONE_SCROLLING_ROOM_LIST__24_ROOMS__V1_1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SYSTEMINITIALIZED__DigitalInput__ = 0;
const uint SCROLLFIRST__DigitalInput__ = 1;
const uint SCROLLLAST__DigitalInput__ = 2;
const uint SCROLLPREVIOUS__DigitalInput__ = 3;
const uint SCROLLNEXT__DigitalInput__ = 4;
const uint SCROLLLINEUP__DigitalInput__ = 5;
const uint SCROLLLINEDOWN__DigitalInput__ = 6;
const uint SCROLLSELECT__DigitalInput__ = 7;
const uint PREVENTSCROLLSELECT__DigitalInput__ = 8;
const uint ONROOMSELECTPAGE__DigitalInput__ = 9;
const uint ONSOURCESHARINGPAGE__DigitalInput__ = 10;
const uint COMBINEROOMANDSOURCENAMES__DigitalInput__ = 11;
const uint SOURCESHAREALL__DigitalInput__ = 12;
const uint OMNIVOLUMEACTIVE__DigitalInput__ = 13;
const uint HIGHLIGHTEDVOLUMEUP__DigitalInput__ = 14;
const uint HIGHLIGHTEDVOLUMEDOWN__DigitalInput__ = 15;
const uint ITEMSELECTED__DigitalInput__ = 16;
const uint ROOMDISABLED__DigitalInput__ = 21;
const uint ROOMFIXEDMODEON__DigitalInput__ = 45;
const uint LINEVOLUMEUP__DigitalInput__ = 69;
const uint LINEVOLUMEDOWN__DigitalInput__ = 74;
const uint SCROLLPAGESIZE__AnalogSerialInput__ = 0;
const uint SELECTEDROOM__AnalogSerialInput__ = 1;
const uint SOURCESHAREEXCLUDEDROOM__AnalogSerialInput__ = 2;
const uint LISTPOSITION__AnalogSerialInput__ = 3;
const uint ROOMSOURCE__AnalogSerialInput__ = 27;
const uint ROOMICONSIN__AnalogSerialInput__ = 51;
const uint ROOMVOLUMEFB__AnalogSerialInput__ = 75;
const uint ROOMNAMEIN__DOLLAR____AnalogSerialInput__ = 99;
const uint SOURCENAMEIN__DOLLAR____AnalogSerialInput__ = 123;
const uint NOWPLAYINGLINE1IN__DOLLAR____AnalogSerialInput__ = 147;
const uint NOWPLAYINGLINE2IN__DOLLAR____AnalogSerialInput__ = 171;
const uint NOWPLAYINGTRANSPORTIN__DOLLAR____AnalogSerialInput__ = 195;
const uint SHOWSCROLLCONTROLS__DigitalOutput__ = 0;
const uint SHOWSECONDARYSUBPAGES__DigitalOutput__ = 1;
const uint ITEMSELECTEDFB__DigitalOutput__ = 2;
const uint LINECHECKEDFB__DigitalOutput__ = 7;
const uint ROOMSELECTED__DigitalOutput__ = 12;
const uint SCROLLHIGHLIGHTFB__DigitalOutput__ = 36;
const uint SHOWLINE__DigitalOutput__ = 41;
const uint LINEVALID__DigitalOutput__ = 46;
const uint SHOWLINEOMNIVOLUME__DigitalOutput__ = 51;
const uint OMNIVOLUMEUP__DigitalOutput__ = 56;
const uint OMNIVOLUMEDOWN__DigitalOutput__ = 80;
const uint SCROLLBAR__AnalogSerialOutput__ = 0;
const uint CURRENTROOM__DOLLAR____AnalogSerialOutput__ = 1;
const uint SOURCESHAREROOMSOURCE__AnalogSerialOutput__ = 2;
const uint ACTIVEBUTTONMODE__AnalogSerialOutput__ = 26;
const uint INACTIVEBUTTONMODE__AnalogSerialOutput__ = 31;
const uint ROOMICONSOUT__AnalogSerialOutput__ = 36;
const uint LINEVOLUMEFB__AnalogSerialOutput__ = 41;
const uint ROOMNAMEOUT__DOLLAR____AnalogSerialOutput__ = 46;
const uint SOURCENAMEOUT__DOLLAR____AnalogSerialOutput__ = 51;
const uint NOWPLAYINGLINE1OUT__DOLLAR____AnalogSerialOutput__ = 56;
const uint NOWPLAYINGLINE2OUT__DOLLAR____AnalogSerialOutput__ = 61;
const uint NOWPLAYINGTRANSPORTOUT__DOLLAR____AnalogSerialOutput__ = 66;

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
