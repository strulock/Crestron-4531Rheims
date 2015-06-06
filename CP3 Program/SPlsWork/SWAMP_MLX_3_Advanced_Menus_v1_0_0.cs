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

namespace CrestronModule_SWAMP_MLX_3_ADVANCED_MENUS_V1_0_0
{
    public class CrestronModuleClass_SWAMP_MLX_3_ADVANCED_MENUS_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOMANDSOURCEMENUINITIALIZED;
        Crestron.Logos.SplusObjects.DigitalInput SOURCELISTHASONEITEM;
        Crestron.Logos.SplusObjects.DigitalInput REFRESHOPTIONSMENU;
        Crestron.Logos.SplusObjects.DigitalInput ROOMISON;
        Crestron.Logos.SplusObjects.DigitalInput HASSOURCES;
        Crestron.Logos.SplusObjects.DigitalInput SOURCESHAREAVAILABLE;
        Crestron.Logos.SplusObjects.DigitalInput HASROOMS;
        Crestron.Logos.SplusObjects.DigitalInput HASSLEEP;
        Crestron.Logos.SplusObjects.DigitalInput HASGROUPS;
        Crestron.Logos.SplusObjects.DigitalInput TOOLSMENUENABLED;
        Crestron.Logos.SplusObjects.DigitalInput GROUPSMENUENABLED;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPISON;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPISOFF;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPWARNINGACTIVATED;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPWARNINGISACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput LOUDNESSISON;
        Crestron.Logos.SplusObjects.DigitalInput LOUDNESSISOFF;
        Crestron.Logos.SplusObjects.DigitalInput ONSLEEPPAGE;
        Crestron.Logos.SplusObjects.DigitalInput ONTOOLSPAGE;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPSELECTBUTTON;
        Crestron.Logos.SplusObjects.DigitalInput TOOLSSELECTBUTTON;
        Crestron.Logos.SplusObjects.DigitalInput SLEEPBACKBUTTON;
        Crestron.Logos.SplusObjects.DigitalInput TOOLSBACKBUTTON;
        Crestron.Logos.SplusObjects.AnalogInput SINGLESOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ACTIVESOURCE;
        Crestron.Logos.SplusObjects.AnalogInput SLEEPTIME;
        Crestron.Logos.SplusObjects.AnalogInput BASS_DB;
        Crestron.Logos.SplusObjects.AnalogInput TREBLE_DB;
        Crestron.Logos.SplusObjects.AnalogInput EQPRESET;
        Crestron.Logos.SplusObjects.AnalogInput BALANCE;
        Crestron.Logos.SplusObjects.AnalogInput SINGLESOURCEICON;
        Crestron.Logos.SplusObjects.AnalogInput ACTIVESOURCEICON;
        Crestron.Logos.SplusObjects.StringInput SINGLESOURCENAME;
        Crestron.Logos.SplusObjects.StringInput ACTIVESOURCENAME__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> GROUPSCONFIGURED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> GROUPSACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> OPTIONSLINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SLEEPLINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TOOLSLINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> GROUPSLINESELECTED;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> GROUPSNAMES;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOAUDIOMENUPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOSOURCESPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOSOURCESHARINGPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOROOMSPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOSLEEPPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOTOOLSPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput GOTOGROUPSPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput SLEEPTIMEADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput SLEEPENABLEADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput BASSADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput TREBLEADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput EQPRESETADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput BALANCEADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput LOUDNESSADJUSTACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTSINGLESOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput SHIFTOPTIONSHIGHLIGHTTOTOP;
        Crestron.Logos.SplusObjects.AnalogOutput OPTIONSHIGHLIGHTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput OPTIONSITEMCOUNTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput SLEEPITEMCOUNTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput TOOLSITEMCOUNTOUT;
        Crestron.Logos.SplusObjects.AnalogOutput GROUPSITEMCOUNTOUT;
        Crestron.Logos.SplusObjects.StringOutput OPTIONSLABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SLEEPLABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TOOLSLABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput GROUPSLABEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SLEEPWARNINGMESSAGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> TOGGLEGROUPS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> GOTOSOURCECONTROLPAGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OPTIONSITEMSACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SLEEPITEMSACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> TOOLSITEMSACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OPTIONSICONSOUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> GROUPSICONSOUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> OPTIONSITEMS__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SLEEPITEMS__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TOOLSITEMS__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> GROUPSITEMS__DOLLAR__;
        ushort OPTIONSITEMCOUNT = 0;
        ushort [] OPTIONSMENUMAP;
        ushort [] OPTIONSMENUICONS;
        CrestronString [] OPTIONSMENU__DOLLAR__;
        short SIGNEDBASS = 0;
        short SIGNEDTREBLE = 0;
        short SIGNEDBALANCE = 0;
        ushort SLEEPMENUPOSITION = 0;
        CrestronString [] EQPRESETNAMES__DOLLAR__;
        ushort GROUPSITEMCOUNT = 0;
        ushort [] GROUPSMENUMAP;
        private void GENERATEOPTIONSMENU (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 212;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( 0 < OPTIONSITEMCOUNT ))  ) ) 
                { 
                __context__.SourceCodeLine = 214;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)OPTIONSITEMCOUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 216;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 218;
                        OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 1 ]  ) ; 
                        __context__.SourceCodeLine = 219;
                        OPTIONSICONSOUT [ I]  .Value = (ushort) ( ACTIVESOURCEICON  .UshortValue ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 221;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 223;
                            OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 2 ]  ) ; 
                            __context__.SourceCodeLine = 224;
                            OPTIONSICONSOUT [ I]  .Value = (ushort) ( 200 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 226;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 3))  ) ) 
                                { 
                                __context__.SourceCodeLine = 228;
                                OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 3 ]  ) ; 
                                __context__.SourceCodeLine = 229;
                                OPTIONSICONSOUT [ I]  .Value = (ushort) ( 201 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 231;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 4))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 233;
                                    OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 4 ]  ) ; 
                                    __context__.SourceCodeLine = 234;
                                    OPTIONSICONSOUT [ I]  .Value = (ushort) ( 202 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 236;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 5))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 238;
                                        OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 5 ]  ) ; 
                                        __context__.SourceCodeLine = 239;
                                        OPTIONSICONSOUT [ I]  .Value = (ushort) ( 203 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 241;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 6))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 243;
                                            OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 6 ]  ) ; 
                                            __context__.SourceCodeLine = 244;
                                            OPTIONSICONSOUT [ I]  .Value = (ushort) ( 204 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 246;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 7))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 248;
                                                OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 7 ]  ) ; 
                                                __context__.SourceCodeLine = 249;
                                                OPTIONSICONSOUT [ I]  .Value = (ushort) ( 206 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 251;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 101))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 253;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ACTIVESOURCE  .UshortValue != 0) ) && Functions.TestForTrue ( Functions.BoolToInt (SINGLESOURCE  .UshortValue == ACTIVESOURCE  .UshortValue) )) ))  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 254;
                                                        OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( OPTIONSMENU__DOLLAR__ [ 1 ]  ) ; 
                                                        }
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 256;
                                                        OPTIONSITEMS__DOLLAR__ [ I]  .UpdateValue ( SINGLESOURCENAME  ) ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 258;
                                                    OPTIONSICONSOUT [ I]  .Value = (ushort) ( SINGLESOURCEICON  .UshortValue ) ; 
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 214;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 263;
            OPTIONSITEMCOUNTOUT  .Value = (ushort) ( OPTIONSITEMCOUNT ) ; 
            __context__.SourceCodeLine = 265;
            OPTIONSLABEL__DOLLAR__  .UpdateValue ( "Media"  ) ; 
            
            }
            
        private void GENERATESLEEPMENU (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 271;
            SLEEPLABEL__DOLLAR__  .UpdateValue ( "Sleep"  ) ; 
            __context__.SourceCodeLine = 272;
            SLEEPITEMCOUNTOUT  .Value = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 274;
            MakeString ( SLEEPITEMS__DOLLAR__ [ 2] , "Time: {0:d} minutes", (short)SLEEPTIME  .UshortValue) ; 
            __context__.SourceCodeLine = 276;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPISON  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 277;
                SLEEPITEMS__DOLLAR__ [ 1]  .UpdateValue ( "Sleep: On"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 278;
                if ( Functions.TestForTrue  ( ( SLEEPISOFF  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 279;
                    SLEEPITEMS__DOLLAR__ [ 1]  .UpdateValue ( "Sleep: Off"  ) ; 
                    }
                
                }
            
            
            }
            
        private void GENERATETOOLSMENU (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 285;
            TOOLSLABEL__DOLLAR__  .UpdateValue ( "Tools"  ) ; 
            __context__.SourceCodeLine = 286;
            TOOLSITEMCOUNTOUT  .Value = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 288;
            SIGNEDBASS = (short) ( BASS_DB  .ShortValue ) ; 
            __context__.SourceCodeLine = 289;
            SIGNEDTREBLE = (short) ( TREBLE_DB  .ShortValue ) ; 
            __context__.SourceCodeLine = 290;
            SIGNEDBALANCE = (short) ( BALANCE  .ShortValue ) ; 
            __context__.SourceCodeLine = 292;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.ToSignedLongInteger( -( 10 ) ) < SIGNEDBASS ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIGNEDBASS < 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 293;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 1] , "Bass: -0.{0:d} dB", (short)Functions.Abs( Mod( SIGNEDBASS , 10 ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 295;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 1] , "Bass: {0:d}.{1:d} dB", (short)(SIGNEDBASS / 10), (short)Functions.Abs( Mod( SIGNEDBASS , 10 ) )) ; 
                }
            
            __context__.SourceCodeLine = 297;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.ToSignedLongInteger( -( 10 ) ) < SIGNEDTREBLE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIGNEDTREBLE < 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 298;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 2] , "Treble: -0.{0:d} dB", (short)Functions.Abs( Mod( SIGNEDTREBLE , 10 ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 300;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 2] , "Treble: {0:d}.{1:d} dB", (short)(SIGNEDTREBLE / 10), (short)Functions.Abs( Mod( SIGNEDTREBLE , 10 ) )) ; 
                }
            
            __context__.SourceCodeLine = 302;
            MakeString ( TOOLSITEMS__DOLLAR__ [ 3] , "EQ: {0}", EQPRESETNAMES__DOLLAR__ [ EQPRESET  .UshortValue ] ) ; 
            __context__.SourceCodeLine = 304;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIGNEDBALANCE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 305;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Center") ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 306;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIGNEDBALANCE < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 307;
                    MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Left     {0:d}", (short)Functions.Abs( SIGNEDBALANCE )) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 308;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIGNEDBALANCE > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 309;
                        MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Right   {0:d}", (short)Functions.Abs( SIGNEDBALANCE )) ; 
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 311;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LOUDNESSISON  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 312;
                TOOLSITEMS__DOLLAR__ [ 5]  .UpdateValue ( "Loudness: On"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 313;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LOUDNESSISOFF  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 314;
                    TOOLSITEMS__DOLLAR__ [ 5]  .UpdateValue ( "Loudness: Off"  ) ; 
                    }
                
                }
            
            
            }
            
        private void GENERATEGROUPSMENU (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 322;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)GROUPSITEMCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 324;
                GROUPSITEMS__DOLLAR__ [ I]  .UpdateValue ( GROUPSNAMES [ GROUPSMENUMAP[ I ] ]  ) ; 
                __context__.SourceCodeLine = 326;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GROUPSACTIVE[ GROUPSMENUMAP[ I ] ] .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 327;
                    GROUPSICONSOUT [ I]  .Value = (ushort) ( 3 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 329;
                    GROUPSICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                    }
                
                __context__.SourceCodeLine = 322;
                } 
            
            __context__.SourceCodeLine = 332;
            GROUPSITEMCOUNTOUT  .Value = (ushort) ( GROUPSITEMCOUNT ) ; 
            __context__.SourceCodeLine = 334;
            GROUPSLABEL__DOLLAR__  .UpdateValue ( "Groups"  ) ; 
            
            }
            
        private void GENERATEOPTIONSMENUMAP (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 341;
            OPTIONSITEMCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 344;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ACTIVESOURCE  .UshortValue != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 346;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCELISTHASONEITEM  .Value == 0) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SOURCELISTHASONEITEM  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (SINGLESOURCE  .UshortValue != ACTIVESOURCE  .UshortValue) )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 348;
                    OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                    __context__.SourceCodeLine = 349;
                    OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 353;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (HASSOURCES  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (SOURCELISTHASONEITEM  .Value == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 355;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 356;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 2 ) ; 
                } 
            
            __context__.SourceCodeLine = 359;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCELISTHASONEITEM  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 361;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 362;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 101 ) ; 
                } 
            
            __context__.SourceCodeLine = 365;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURCESHAREAVAILABLE  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 367;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 368;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 3 ) ; 
                } 
            
            __context__.SourceCodeLine = 371;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASROOMS  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 373;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 374;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 4 ) ; 
                } 
            
            __context__.SourceCodeLine = 377;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (HASSLEEP  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ACTIVESOURCE  .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 379;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 380;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 381;
                SLEEPMENUPOSITION = (ushort) ( OPTIONSITEMCOUNT ) ; 
                } 
            
            __context__.SourceCodeLine = 384;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (ACTIVESOURCE  .UshortValue != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 386;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 387;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 6 ) ; 
                } 
            
            __context__.SourceCodeLine = 390;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (HASGROUPS  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (GROUPSMENUENABLED  .Value == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 392;
                OPTIONSITEMCOUNT = (ushort) ( (OPTIONSITEMCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 393;
                OPTIONSMENUMAP [ OPTIONSITEMCOUNT] = (ushort) ( 7 ) ; 
                } 
            
            __context__.SourceCodeLine = 397;
            GENERATEOPTIONSMENU (  __context__  ) ; 
            
            }
            
        private void GENERATEGROUPSMENUMAP (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 405;
            GROUPSITEMCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 407;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)6; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 409;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GROUPSCONFIGURED[ I ] .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 411;
                    GROUPSITEMCOUNT = (ushort) ( (GROUPSITEMCOUNT + 1) ) ; 
                    __context__.SourceCodeLine = 412;
                    GROUPSMENUMAP [ GROUPSITEMCOUNT] = (ushort) ( I ) ; 
                    } 
                
                __context__.SourceCodeLine = 407;
                } 
            
            __context__.SourceCodeLine = 416;
            GENERATEGROUPSMENU (  __context__  ) ; 
            
            }
            
        object ROOMANDSOURCEMENUINITIALIZED_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 423;
                GENERATEOPTIONSMENUMAP (  __context__  ) ; 
                __context__.SourceCodeLine = 425;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSLEEP  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 426;
                    GENERATESLEEPMENU (  __context__  ) ; 
                    }
                
                __context__.SourceCodeLine = 428;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 429;
                    GENERATETOOLSMENU (  __context__  ) ; 
                    }
                
                __context__.SourceCodeLine = 431;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (HASGROUPS  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (GROUPSMENUENABLED  .Value == 1) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 432;
                    GENERATEGROUPSMENUMAP (  __context__  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object REFRESHOPTIONSMENU_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 438;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMANDSOURCEMENUINITIALIZED  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 440;
                GENERATEOPTIONSMENUMAP (  __context__  ) ; 
                __context__.SourceCodeLine = 442;
                OPTIONSHIGHLIGHTOUT  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 443;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 445;
                SHIFTOPTIONSHIGHLIGHTTOTOP  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 446;
                SHIFTOPTIONSHIGHLIGHTTOTOP  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object HASSLEEP_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 453;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSLEEP  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 454;
            GENERATESLEEPMENU (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOOLSMENUENABLED_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 460;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 461;
            GENERATETOOLSMENU (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPISON_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 467;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSLEEP  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 468;
            SLEEPITEMS__DOLLAR__ [ 1]  .UpdateValue ( "Sleep: On"  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPISOFF_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 474;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSLEEP  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 475;
            SLEEPITEMS__DOLLAR__ [ 1]  .UpdateValue ( "Sleep: Off"  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOUDNESSISON_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 481;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 482;
            TOOLSITEMS__DOLLAR__ [ 5]  .UpdateValue ( "Loudness: On"  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOUDNESSISOFF_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 488;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 489;
            TOOLSITEMS__DOLLAR__ [ 5]  .UpdateValue ( "Loudness: Off"  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONSLEEPPAGE_OnRelease_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 495;
        SLEEPTIMEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 496;
        SLEEPENABLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 498;
        SLEEPITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 499;
        SLEEPITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONTOOLSPAGE_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 505;
        BASSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 506;
        TREBLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 507;
        EQPRESETADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 508;
        BALANCEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 509;
        LOUDNESSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 511;
        TOOLSITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 512;
        TOOLSITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 513;
        TOOLSITEMSACTIVE [ 3]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 514;
        TOOLSITEMSACTIVE [ 4]  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 515;
        TOOLSITEMSACTIVE [ 5]  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPWARNINGACTIVATED_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 521;
        OPTIONSHIGHLIGHTOUT  .Value = (ushort) ( SLEEPMENUPOSITION ) ; 
        __context__.SourceCodeLine = 522;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 524;
        SHIFTOPTIONSHIGHLIGHTTOTOP  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 525;
        SHIFTOPTIONSHIGHLIGHTTOTOP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 527;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPTIME  .UshortValue == 1))  ) ) 
            {
            __context__.SourceCodeLine = 528;
            MakeString ( SLEEPWARNINGMESSAGE , "Sleep in {0:d} minute", (short)SLEEPTIME  .UshortValue) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 530;
            MakeString ( SLEEPWARNINGMESSAGE , "Sleep in {0:d} minutes", (short)SLEEPTIME  .UshortValue) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPSELECTBUTTON_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 536;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SLEEPTIMEADJUSTACTIVE  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (SLEEPENABLEADJUSTACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 538;
            SLEEPTIMEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 539;
            SLEEPENABLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 541;
            SLEEPITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 542;
            SLEEPITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOOLSSELECTBUTTON_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 549;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (BASSADJUSTACTIVE  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (TREBLEADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (EQPRESETADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (BALANCEADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (LOUDNESSADJUSTACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 551;
            BASSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 552;
            TREBLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 553;
            EQPRESETADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 554;
            BALANCEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 555;
            LOUDNESSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 557;
            TOOLSITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 558;
            TOOLSITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 559;
            TOOLSITEMSACTIVE [ 3]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 560;
            TOOLSITEMSACTIVE [ 4]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 561;
            TOOLSITEMSACTIVE [ 5]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPBACKBUTTON_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 568;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SLEEPTIMEADJUSTACTIVE  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (SLEEPENABLEADJUSTACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 570;
            SLEEPTIMEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 571;
            SLEEPENABLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 573;
            SLEEPITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 574;
            SLEEPITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 578;
            GOTOAUDIOMENUPAGE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 579;
            GOTOAUDIOMENUPAGE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOOLSBACKBUTTON_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 586;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (BASSADJUSTACTIVE  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (TREBLEADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (EQPRESETADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (BALANCEADJUSTACTIVE  .Value == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (LOUDNESSADJUSTACTIVE  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 588;
            BASSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 589;
            TREBLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 590;
            EQPRESETADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 591;
            BALANCEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 592;
            LOUDNESSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 594;
            TOOLSITEMSACTIVE [ 1]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 595;
            TOOLSITEMSACTIVE [ 2]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 596;
            TOOLSITEMSACTIVE [ 3]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 597;
            TOOLSITEMSACTIVE [ 4]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 598;
            TOOLSITEMSACTIVE [ 5]  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 602;
            GOTOAUDIOMENUPAGE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 603;
            GOTOAUDIOMENUPAGE  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPTIME_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 610;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASSLEEP  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 611;
            MakeString ( SLEEPITEMS__DOLLAR__ [ 2] , "Time: {0:d} minutes", (short)SLEEPTIME  .UshortValue) ; 
            }
        
        __context__.SourceCodeLine = 613;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPWARNINGISACTIVE  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 615;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPTIME  .UshortValue == 1))  ) ) 
                {
                __context__.SourceCodeLine = 616;
                MakeString ( SLEEPWARNINGMESSAGE , "Sleep in {0:d} minute", (short)SLEEPTIME  .UshortValue) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 618;
                MakeString ( SLEEPWARNINGMESSAGE , "Sleep in {0:d} minutes", (short)SLEEPTIME  .UshortValue) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BASS_DB_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 625;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 627;
            SIGNEDBASS = (short) ( BASS_DB  .ShortValue ) ; 
            __context__.SourceCodeLine = 629;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.ToSignedLongInteger( -( 10 ) ) < SIGNEDBASS ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIGNEDBASS < 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 630;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 1] , "Bass: -0.{0:d} dB", (short)Functions.Abs( Mod( SIGNEDBASS , 10 ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 632;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 1] , "Bass: {0:d}.{1:d} dB", (short)(SIGNEDBASS / 10), (short)Functions.Abs( Mod( SIGNEDBASS , 10 ) )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TREBLE_DB_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 639;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 641;
            SIGNEDTREBLE = (short) ( TREBLE_DB  .ShortValue ) ; 
            __context__.SourceCodeLine = 643;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.ToSignedLongInteger( -( 10 ) ) < SIGNEDTREBLE ) ) && Functions.TestForTrue ( Functions.BoolToInt ( SIGNEDTREBLE < 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 644;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 2] , "Treble: -0.{0:d} dB", (short)Functions.Abs( Mod( SIGNEDTREBLE , 10 ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 646;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 2] , "Treble: {0:d}.{1:d} dB", (short)(SIGNEDTREBLE / 10), (short)Functions.Abs( Mod( SIGNEDTREBLE , 10 ) )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EQPRESET_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 653;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 655;
            MakeString ( TOOLSITEMS__DOLLAR__ [ 3] , "EQ: {0}", EQPRESETNAMES__DOLLAR__ [ EQPRESET  .UshortValue ] ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BALANCE_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 662;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TOOLSMENUENABLED  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 664;
            SIGNEDBALANCE = (short) ( BALANCE  .ShortValue ) ; 
            __context__.SourceCodeLine = 666;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIGNEDBALANCE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 667;
                MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Center") ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 668;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIGNEDBALANCE < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 669;
                    MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Left     {0:d}", (short)Functions.Abs( SIGNEDBALANCE )) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 670;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIGNEDBALANCE > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 671;
                        MakeString ( TOOLSITEMS__DOLLAR__ [ 4] , "Balance: Right   {0:d}", (short)Functions.Abs( SIGNEDBALANCE )) ; 
                        }
                    
                    }
                
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OPTIONSLINESELECTED_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        
        __context__.SourceCodeLine = 680;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 682;
        switch ((int)OPTIONSMENUMAP[ SELECTEDLINE ])
        
            { 
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 686;
                GOTOSOURCECONTROLPAGE [ ACTIVESOURCE  .UshortValue]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 687;
                GOTOSOURCECONTROLPAGE [ ACTIVESOURCE  .UshortValue]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 688;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 693;
                GOTOSOURCESPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 694;
                GOTOSOURCESPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 695;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 700;
                GOTOSOURCESHARINGPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 701;
                GOTOSOURCESHARINGPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 702;
                break ; 
                } 
            
            goto case 4 ;
            case 4 : 
            
                { 
                __context__.SourceCodeLine = 707;
                GOTOROOMSPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 708;
                GOTOROOMSPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 709;
                break ; 
                } 
            
            goto case 5 ;
            case 5 : 
            
                { 
                __context__.SourceCodeLine = 714;
                GOTOSLEEPPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 715;
                GOTOSLEEPPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 716;
                break ; 
                } 
            
            goto case 6 ;
            case 6 : 
            
                { 
                __context__.SourceCodeLine = 721;
                GOTOTOOLSPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 722;
                GOTOTOOLSPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 723;
                break ; 
                } 
            
            goto case 7 ;
            case 7 : 
            
                { 
                __context__.SourceCodeLine = 728;
                GOTOGROUPSPAGE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 729;
                GOTOGROUPSPAGE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 730;
                break ; 
                } 
            
            goto case 101 ;
            case 101 : 
            
                { 
                __context__.SourceCodeLine = 735;
                SELECTSINGLESOURCE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 736;
                SELECTSINGLESOURCE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 737;
                break ; 
                } 
            
            break;
            } 
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEPLINESELECTED_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        
        __context__.SourceCodeLine = 747;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 749;
        switch ((int)SELECTEDLINE)
        
            { 
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 753;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPTIMEADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 755;
                    SLEEPITEMSACTIVE [ 2]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 756;
                    SLEEPTIMEADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 759;
                break ; 
                } 
            
            goto case 1 ;
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 764;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLEEPENABLEADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 766;
                    SLEEPITEMSACTIVE [ 1]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 767;
                    SLEEPENABLEADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 770;
                break ; 
                } 
            
            break;
            } 
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOOLSLINESELECTED_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        
        __context__.SourceCodeLine = 780;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 782;
        switch ((int)SELECTEDLINE)
        
            { 
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 786;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BASSADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 788;
                    TOOLSITEMSACTIVE [ 1]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 789;
                    BASSADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 792;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 797;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TREBLEADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 799;
                    TOOLSITEMSACTIVE [ 2]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 800;
                    TREBLEADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 803;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 808;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EQPRESETADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 810;
                    TOOLSITEMSACTIVE [ 3]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 811;
                    EQPRESETADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 814;
                break ; 
                } 
            
            goto case 4 ;
            case 4 : 
            
                { 
                __context__.SourceCodeLine = 819;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BALANCEADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 821;
                    TOOLSITEMSACTIVE [ 4]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 822;
                    BALANCEADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 825;
                break ; 
                } 
            
            goto case 5 ;
            case 5 : 
            
                { 
                __context__.SourceCodeLine = 830;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LOUDNESSADJUSTACTIVE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 832;
                    TOOLSITEMSACTIVE [ 5]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 833;
                    LOUDNESSADJUSTACTIVE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 836;
                break ; 
                } 
            
            break;
            } 
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPSLINESELECTED_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SELECTEDLINE = 0;
        
        
        __context__.SourceCodeLine = 846;
        SELECTEDLINE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 848;
        TOGGLEGROUPS [ GROUPSMENUMAP[ SELECTEDLINE ]]  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 849;
        TOGGLEGROUPS [ GROUPSMENUMAP[ SELECTEDLINE ]]  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ACTIVESOURCEICON_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 857;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( 0 < OPTIONSITEMCOUNT ))  ) ) 
            { 
            __context__.SourceCodeLine = 859;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)OPTIONSITEMCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 861;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONSMENUMAP[ I ] == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 862;
                    OPTIONSICONSOUT [ I]  .Value = (ushort) ( ACTIVESOURCEICON  .UshortValue ) ; 
                    }
                
                __context__.SourceCodeLine = 859;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUPSACTIVE_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort GROUPCHANGED = 0;
        
        
        __context__.SourceCodeLine = 873;
        GROUPCHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 875;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)GROUPSITEMCOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 877;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GROUPSMENUMAP[ I ] == GROUPCHANGED))  ) ) 
                { 
                __context__.SourceCodeLine = 879;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GROUPSACTIVE[ GROUPCHANGED ] .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 880;
                    GROUPSICONSOUT [ I]  .Value = (ushort) ( 3 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 882;
                    GROUPSICONSOUT [ I]  .Value = (ushort) ( 0 ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 875;
            } 
        
        
        
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
        
        __context__.SourceCodeLine = 908;
        OPTIONSMENU__DOLLAR__ [ 1 ]  .UpdateValue ( "Control"  ) ; 
        __context__.SourceCodeLine = 909;
        OPTIONSMENU__DOLLAR__ [ 2 ]  .UpdateValue ( "Sources"  ) ; 
        __context__.SourceCodeLine = 910;
        OPTIONSMENU__DOLLAR__ [ 3 ]  .UpdateValue ( "Share Source"  ) ; 
        __context__.SourceCodeLine = 911;
        OPTIONSMENU__DOLLAR__ [ 4 ]  .UpdateValue ( "Rooms"  ) ; 
        __context__.SourceCodeLine = 912;
        OPTIONSMENU__DOLLAR__ [ 5 ]  .UpdateValue ( "Sleep"  ) ; 
        __context__.SourceCodeLine = 913;
        OPTIONSMENU__DOLLAR__ [ 6 ]  .UpdateValue ( "Tools"  ) ; 
        __context__.SourceCodeLine = 914;
        OPTIONSMENU__DOLLAR__ [ 7 ]  .UpdateValue ( "Groups"  ) ; 
        __context__.SourceCodeLine = 916;
        EQPRESETNAMES__DOLLAR__ [ 0 ]  .UpdateValue ( "Off"  ) ; 
        __context__.SourceCodeLine = 917;
        EQPRESETNAMES__DOLLAR__ [ 1 ]  .UpdateValue ( "Classical"  ) ; 
        __context__.SourceCodeLine = 918;
        EQPRESETNAMES__DOLLAR__ [ 2 ]  .UpdateValue ( "Jazz"  ) ; 
        __context__.SourceCodeLine = 919;
        EQPRESETNAMES__DOLLAR__ [ 3 ]  .UpdateValue ( "Pop"  ) ; 
        __context__.SourceCodeLine = 920;
        EQPRESETNAMES__DOLLAR__ [ 4 ]  .UpdateValue ( "Rock"  ) ; 
        __context__.SourceCodeLine = 921;
        EQPRESETNAMES__DOLLAR__ [ 5 ]  .UpdateValue ( "Spoken Word"  ) ; 
        __context__.SourceCodeLine = 923;
        SLEEPTIMEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 924;
        SLEEPENABLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 925;
        BASSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 926;
        TREBLEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 927;
        BALANCEADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 928;
        LOUDNESSADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 929;
        EQPRESETADJUSTACTIVE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    OPTIONSMENUMAP  = new ushort[ 8 ];
    OPTIONSMENUICONS  = new ushort[ 8 ];
    GROUPSMENUMAP  = new ushort[ 7 ];
    OPTIONSMENU__DOLLAR__  = new CrestronString[ 8 ];
    for( uint i = 0; i < 8; i++ )
        OPTIONSMENU__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
    EQPRESETNAMES__DOLLAR__  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        EQPRESETNAMES__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
    
    ROOMANDSOURCEMENUINITIALIZED = new Crestron.Logos.SplusObjects.DigitalInput( ROOMANDSOURCEMENUINITIALIZED__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMANDSOURCEMENUINITIALIZED__DigitalInput__, ROOMANDSOURCEMENUINITIALIZED );
    
    SOURCELISTHASONEITEM = new Crestron.Logos.SplusObjects.DigitalInput( SOURCELISTHASONEITEM__DigitalInput__, this );
    m_DigitalInputList.Add( SOURCELISTHASONEITEM__DigitalInput__, SOURCELISTHASONEITEM );
    
    REFRESHOPTIONSMENU = new Crestron.Logos.SplusObjects.DigitalInput( REFRESHOPTIONSMENU__DigitalInput__, this );
    m_DigitalInputList.Add( REFRESHOPTIONSMENU__DigitalInput__, REFRESHOPTIONSMENU );
    
    ROOMISON = new Crestron.Logos.SplusObjects.DigitalInput( ROOMISON__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMISON__DigitalInput__, ROOMISON );
    
    HASSOURCES = new Crestron.Logos.SplusObjects.DigitalInput( HASSOURCES__DigitalInput__, this );
    m_DigitalInputList.Add( HASSOURCES__DigitalInput__, HASSOURCES );
    
    SOURCESHAREAVAILABLE = new Crestron.Logos.SplusObjects.DigitalInput( SOURCESHAREAVAILABLE__DigitalInput__, this );
    m_DigitalInputList.Add( SOURCESHAREAVAILABLE__DigitalInput__, SOURCESHAREAVAILABLE );
    
    HASROOMS = new Crestron.Logos.SplusObjects.DigitalInput( HASROOMS__DigitalInput__, this );
    m_DigitalInputList.Add( HASROOMS__DigitalInput__, HASROOMS );
    
    HASSLEEP = new Crestron.Logos.SplusObjects.DigitalInput( HASSLEEP__DigitalInput__, this );
    m_DigitalInputList.Add( HASSLEEP__DigitalInput__, HASSLEEP );
    
    HASGROUPS = new Crestron.Logos.SplusObjects.DigitalInput( HASGROUPS__DigitalInput__, this );
    m_DigitalInputList.Add( HASGROUPS__DigitalInput__, HASGROUPS );
    
    TOOLSMENUENABLED = new Crestron.Logos.SplusObjects.DigitalInput( TOOLSMENUENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( TOOLSMENUENABLED__DigitalInput__, TOOLSMENUENABLED );
    
    GROUPSMENUENABLED = new Crestron.Logos.SplusObjects.DigitalInput( GROUPSMENUENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( GROUPSMENUENABLED__DigitalInput__, GROUPSMENUENABLED );
    
    SLEEPISON = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPISON__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPISON__DigitalInput__, SLEEPISON );
    
    SLEEPISOFF = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPISOFF__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPISOFF__DigitalInput__, SLEEPISOFF );
    
    SLEEPWARNINGACTIVATED = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPWARNINGACTIVATED__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPWARNINGACTIVATED__DigitalInput__, SLEEPWARNINGACTIVATED );
    
    SLEEPWARNINGISACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPWARNINGISACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPWARNINGISACTIVE__DigitalInput__, SLEEPWARNINGISACTIVE );
    
    LOUDNESSISON = new Crestron.Logos.SplusObjects.DigitalInput( LOUDNESSISON__DigitalInput__, this );
    m_DigitalInputList.Add( LOUDNESSISON__DigitalInput__, LOUDNESSISON );
    
    LOUDNESSISOFF = new Crestron.Logos.SplusObjects.DigitalInput( LOUDNESSISOFF__DigitalInput__, this );
    m_DigitalInputList.Add( LOUDNESSISOFF__DigitalInput__, LOUDNESSISOFF );
    
    ONSLEEPPAGE = new Crestron.Logos.SplusObjects.DigitalInput( ONSLEEPPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ONSLEEPPAGE__DigitalInput__, ONSLEEPPAGE );
    
    ONTOOLSPAGE = new Crestron.Logos.SplusObjects.DigitalInput( ONTOOLSPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( ONTOOLSPAGE__DigitalInput__, ONTOOLSPAGE );
    
    SLEEPSELECTBUTTON = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPSELECTBUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPSELECTBUTTON__DigitalInput__, SLEEPSELECTBUTTON );
    
    TOOLSSELECTBUTTON = new Crestron.Logos.SplusObjects.DigitalInput( TOOLSSELECTBUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( TOOLSSELECTBUTTON__DigitalInput__, TOOLSSELECTBUTTON );
    
    SLEEPBACKBUTTON = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPBACKBUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( SLEEPBACKBUTTON__DigitalInput__, SLEEPBACKBUTTON );
    
    TOOLSBACKBUTTON = new Crestron.Logos.SplusObjects.DigitalInput( TOOLSBACKBUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( TOOLSBACKBUTTON__DigitalInput__, TOOLSBACKBUTTON );
    
    GROUPSCONFIGURED = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSCONFIGURED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( GROUPSCONFIGURED__DigitalInput__ + i, GROUPSCONFIGURED__DigitalInput__, this );
        m_DigitalInputList.Add( GROUPSCONFIGURED__DigitalInput__ + i, GROUPSCONFIGURED[i+1] );
    }
    
    GROUPSACTIVE = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( GROUPSACTIVE__DigitalInput__ + i, GROUPSACTIVE__DigitalInput__, this );
        m_DigitalInputList.Add( GROUPSACTIVE__DigitalInput__ + i, GROUPSACTIVE[i+1] );
    }
    
    OPTIONSLINESELECTED = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        OPTIONSLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( OPTIONSLINESELECTED__DigitalInput__ + i, OPTIONSLINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( OPTIONSLINESELECTED__DigitalInput__ + i, OPTIONSLINESELECTED[i+1] );
    }
    
    SLEEPLINESELECTED = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        SLEEPLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SLEEPLINESELECTED__DigitalInput__ + i, SLEEPLINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( SLEEPLINESELECTED__DigitalInput__ + i, SLEEPLINESELECTED[i+1] );
    }
    
    TOOLSLINESELECTED = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TOOLSLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TOOLSLINESELECTED__DigitalInput__ + i, TOOLSLINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( TOOLSLINESELECTED__DigitalInput__ + i, TOOLSLINESELECTED[i+1] );
    }
    
    GROUPSLINESELECTED = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSLINESELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( GROUPSLINESELECTED__DigitalInput__ + i, GROUPSLINESELECTED__DigitalInput__, this );
        m_DigitalInputList.Add( GROUPSLINESELECTED__DigitalInput__ + i, GROUPSLINESELECTED[i+1] );
    }
    
    GOTOAUDIOMENUPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOAUDIOMENUPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOAUDIOMENUPAGE__DigitalOutput__, GOTOAUDIOMENUPAGE );
    
    GOTOSOURCESPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOSOURCESPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOSOURCESPAGE__DigitalOutput__, GOTOSOURCESPAGE );
    
    GOTOSOURCESHARINGPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOSOURCESHARINGPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOSOURCESHARINGPAGE__DigitalOutput__, GOTOSOURCESHARINGPAGE );
    
    GOTOROOMSPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOROOMSPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOROOMSPAGE__DigitalOutput__, GOTOROOMSPAGE );
    
    GOTOSLEEPPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOSLEEPPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOSLEEPPAGE__DigitalOutput__, GOTOSLEEPPAGE );
    
    GOTOTOOLSPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOTOOLSPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOTOOLSPAGE__DigitalOutput__, GOTOTOOLSPAGE );
    
    GOTOGROUPSPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOGROUPSPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GOTOGROUPSPAGE__DigitalOutput__, GOTOGROUPSPAGE );
    
    SLEEPTIMEADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( SLEEPTIMEADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SLEEPTIMEADJUSTACTIVE__DigitalOutput__, SLEEPTIMEADJUSTACTIVE );
    
    SLEEPENABLEADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( SLEEPENABLEADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SLEEPENABLEADJUSTACTIVE__DigitalOutput__, SLEEPENABLEADJUSTACTIVE );
    
    BASSADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( BASSADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( BASSADJUSTACTIVE__DigitalOutput__, BASSADJUSTACTIVE );
    
    TREBLEADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( TREBLEADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( TREBLEADJUSTACTIVE__DigitalOutput__, TREBLEADJUSTACTIVE );
    
    EQPRESETADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( EQPRESETADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( EQPRESETADJUSTACTIVE__DigitalOutput__, EQPRESETADJUSTACTIVE );
    
    BALANCEADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( BALANCEADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( BALANCEADJUSTACTIVE__DigitalOutput__, BALANCEADJUSTACTIVE );
    
    LOUDNESSADJUSTACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( LOUDNESSADJUSTACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( LOUDNESSADJUSTACTIVE__DigitalOutput__, LOUDNESSADJUSTACTIVE );
    
    SELECTSINGLESOURCE = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTSINGLESOURCE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTSINGLESOURCE__DigitalOutput__, SELECTSINGLESOURCE );
    
    SHIFTOPTIONSHIGHLIGHTTOTOP = new Crestron.Logos.SplusObjects.DigitalOutput( SHIFTOPTIONSHIGHLIGHTTOTOP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHIFTOPTIONSHIGHLIGHTTOTOP__DigitalOutput__, SHIFTOPTIONSHIGHLIGHTTOTOP );
    
    TOGGLEGROUPS = new InOutArray<DigitalOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        TOGGLEGROUPS[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( TOGGLEGROUPS__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( TOGGLEGROUPS__DigitalOutput__ + i, TOGGLEGROUPS[i+1] );
    }
    
    GOTOSOURCECONTROLPAGE = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        GOTOSOURCECONTROLPAGE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( GOTOSOURCECONTROLPAGE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( GOTOSOURCECONTROLPAGE__DigitalOutput__ + i, GOTOSOURCECONTROLPAGE[i+1] );
    }
    
    OPTIONSITEMSACTIVE = new InOutArray<DigitalOutput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        OPTIONSITEMSACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OPTIONSITEMSACTIVE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OPTIONSITEMSACTIVE__DigitalOutput__ + i, OPTIONSITEMSACTIVE[i+1] );
    }
    
    SLEEPITEMSACTIVE = new InOutArray<DigitalOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        SLEEPITEMSACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SLEEPITEMSACTIVE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SLEEPITEMSACTIVE__DigitalOutput__ + i, SLEEPITEMSACTIVE[i+1] );
    }
    
    TOOLSITEMSACTIVE = new InOutArray<DigitalOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TOOLSITEMSACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( TOOLSITEMSACTIVE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( TOOLSITEMSACTIVE__DigitalOutput__ + i, TOOLSITEMSACTIVE[i+1] );
    }
    
    SINGLESOURCE = new Crestron.Logos.SplusObjects.AnalogInput( SINGLESOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SINGLESOURCE__AnalogSerialInput__, SINGLESOURCE );
    
    ACTIVESOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ACTIVESOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ACTIVESOURCE__AnalogSerialInput__, ACTIVESOURCE );
    
    SLEEPTIME = new Crestron.Logos.SplusObjects.AnalogInput( SLEEPTIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SLEEPTIME__AnalogSerialInput__, SLEEPTIME );
    
    BASS_DB = new Crestron.Logos.SplusObjects.AnalogInput( BASS_DB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( BASS_DB__AnalogSerialInput__, BASS_DB );
    
    TREBLE_DB = new Crestron.Logos.SplusObjects.AnalogInput( TREBLE_DB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TREBLE_DB__AnalogSerialInput__, TREBLE_DB );
    
    EQPRESET = new Crestron.Logos.SplusObjects.AnalogInput( EQPRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( EQPRESET__AnalogSerialInput__, EQPRESET );
    
    BALANCE = new Crestron.Logos.SplusObjects.AnalogInput( BALANCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( BALANCE__AnalogSerialInput__, BALANCE );
    
    SINGLESOURCEICON = new Crestron.Logos.SplusObjects.AnalogInput( SINGLESOURCEICON__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SINGLESOURCEICON__AnalogSerialInput__, SINGLESOURCEICON );
    
    ACTIVESOURCEICON = new Crestron.Logos.SplusObjects.AnalogInput( ACTIVESOURCEICON__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ACTIVESOURCEICON__AnalogSerialInput__, ACTIVESOURCEICON );
    
    OPTIONSHIGHLIGHTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( OPTIONSHIGHLIGHTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OPTIONSHIGHLIGHTOUT__AnalogSerialOutput__, OPTIONSHIGHLIGHTOUT );
    
    OPTIONSITEMCOUNTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( OPTIONSITEMCOUNTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OPTIONSITEMCOUNTOUT__AnalogSerialOutput__, OPTIONSITEMCOUNTOUT );
    
    SLEEPITEMCOUNTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( SLEEPITEMCOUNTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SLEEPITEMCOUNTOUT__AnalogSerialOutput__, SLEEPITEMCOUNTOUT );
    
    TOOLSITEMCOUNTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( TOOLSITEMCOUNTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TOOLSITEMCOUNTOUT__AnalogSerialOutput__, TOOLSITEMCOUNTOUT );
    
    GROUPSITEMCOUNTOUT = new Crestron.Logos.SplusObjects.AnalogOutput( GROUPSITEMCOUNTOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GROUPSITEMCOUNTOUT__AnalogSerialOutput__, GROUPSITEMCOUNTOUT );
    
    OPTIONSICONSOUT = new InOutArray<AnalogOutput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        OPTIONSICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OPTIONSICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OPTIONSICONSOUT__AnalogSerialOutput__ + i, OPTIONSICONSOUT[i+1] );
    }
    
    GROUPSICONSOUT = new InOutArray<AnalogOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSICONSOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( GROUPSICONSOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( GROUPSICONSOUT__AnalogSerialOutput__ + i, GROUPSICONSOUT[i+1] );
    }
    
    SINGLESOURCENAME = new Crestron.Logos.SplusObjects.StringInput( SINGLESOURCENAME__AnalogSerialInput__, 32, this );
    m_StringInputList.Add( SINGLESOURCENAME__AnalogSerialInput__, SINGLESOURCENAME );
    
    ACTIVESOURCENAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ACTIVESOURCENAME__DOLLAR____AnalogSerialInput__, 32, this );
    m_StringInputList.Add( ACTIVESOURCENAME__DOLLAR____AnalogSerialInput__, ACTIVESOURCENAME__DOLLAR__ );
    
    GROUPSNAMES = new InOutArray<StringInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSNAMES[i+1] = new Crestron.Logos.SplusObjects.StringInput( GROUPSNAMES__AnalogSerialInput__ + i, GROUPSNAMES__AnalogSerialInput__, 32, this );
        m_StringInputList.Add( GROUPSNAMES__AnalogSerialInput__ + i, GROUPSNAMES[i+1] );
    }
    
    OPTIONSLABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OPTIONSLABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OPTIONSLABEL__DOLLAR____AnalogSerialOutput__, OPTIONSLABEL__DOLLAR__ );
    
    SLEEPLABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SLEEPLABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SLEEPLABEL__DOLLAR____AnalogSerialOutput__, SLEEPLABEL__DOLLAR__ );
    
    TOOLSLABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOOLSLABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TOOLSLABEL__DOLLAR____AnalogSerialOutput__, TOOLSLABEL__DOLLAR__ );
    
    GROUPSLABEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( GROUPSLABEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( GROUPSLABEL__DOLLAR____AnalogSerialOutput__, GROUPSLABEL__DOLLAR__ );
    
    SLEEPWARNINGMESSAGE = new Crestron.Logos.SplusObjects.StringOutput( SLEEPWARNINGMESSAGE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SLEEPWARNINGMESSAGE__AnalogSerialOutput__, SLEEPWARNINGMESSAGE );
    
    OPTIONSITEMS__DOLLAR__ = new InOutArray<StringOutput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        OPTIONSITEMS__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( OPTIONSITEMS__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( OPTIONSITEMS__DOLLAR____AnalogSerialOutput__ + i, OPTIONSITEMS__DOLLAR__[i+1] );
    }
    
    SLEEPITEMS__DOLLAR__ = new InOutArray<StringOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        SLEEPITEMS__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SLEEPITEMS__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SLEEPITEMS__DOLLAR____AnalogSerialOutput__ + i, SLEEPITEMS__DOLLAR__[i+1] );
    }
    
    TOOLSITEMS__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TOOLSITEMS__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TOOLSITEMS__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TOOLSITEMS__DOLLAR____AnalogSerialOutput__ + i, TOOLSITEMS__DOLLAR__[i+1] );
    }
    
    GROUPSITEMS__DOLLAR__ = new InOutArray<StringOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        GROUPSITEMS__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( GROUPSITEMS__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( GROUPSITEMS__DOLLAR____AnalogSerialOutput__ + i, GROUPSITEMS__DOLLAR__[i+1] );
    }
    
    
    ROOMANDSOURCEMENUINITIALIZED.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMANDSOURCEMENUINITIALIZED_OnPush_0, false ) );
    REFRESHOPTIONSMENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( REFRESHOPTIONSMENU_OnPush_1, false ) );
    HASSLEEP.OnDigitalChange.Add( new InputChangeHandlerWrapper( HASSLEEP_OnChange_2, false ) );
    TOOLSMENUENABLED.OnDigitalChange.Add( new InputChangeHandlerWrapper( TOOLSMENUENABLED_OnChange_3, false ) );
    SLEEPISON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPISON_OnPush_4, false ) );
    SLEEPISOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPISOFF_OnPush_5, false ) );
    LOUDNESSISON.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOUDNESSISON_OnPush_6, false ) );
    LOUDNESSISOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOUDNESSISOFF_OnPush_7, false ) );
    ONSLEEPPAGE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ONSLEEPPAGE_OnRelease_8, false ) );
    ONTOOLSPAGE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ONTOOLSPAGE_OnRelease_9, false ) );
    SLEEPWARNINGACTIVATED.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPWARNINGACTIVATED_OnPush_10, false ) );
    SLEEPSELECTBUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPSELECTBUTTON_OnPush_11, false ) );
    TOOLSSELECTBUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOOLSSELECTBUTTON_OnPush_12, false ) );
    SLEEPBACKBUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPBACKBUTTON_OnPush_13, false ) );
    TOOLSBACKBUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOOLSBACKBUTTON_OnPush_14, false ) );
    SLEEPTIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( SLEEPTIME_OnChange_15, false ) );
    BASS_DB.OnAnalogChange.Add( new InputChangeHandlerWrapper( BASS_DB_OnChange_16, false ) );
    TREBLE_DB.OnAnalogChange.Add( new InputChangeHandlerWrapper( TREBLE_DB_OnChange_17, false ) );
    EQPRESET.OnAnalogChange.Add( new InputChangeHandlerWrapper( EQPRESET_OnChange_18, false ) );
    BALANCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( BALANCE_OnChange_19, false ) );
    for( uint i = 0; i < 7; i++ )
        OPTIONSLINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( OPTIONSLINESELECTED_OnPush_20, false ) );
        
    for( uint i = 0; i < 2; i++ )
        SLEEPLINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEPLINESELECTED_OnPush_21, false ) );
        
    for( uint i = 0; i < 5; i++ )
        TOOLSLINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TOOLSLINESELECTED_OnPush_22, false ) );
        
    for( uint i = 0; i < 6; i++ )
        GROUPSLINESELECTED[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( GROUPSLINESELECTED_OnPush_23, false ) );
        
    ACTIVESOURCEICON.OnAnalogChange.Add( new InputChangeHandlerWrapper( ACTIVESOURCEICON_OnChange_24, false ) );
    for( uint i = 0; i < 6; i++ )
        GROUPSACTIVE[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( GROUPSACTIVE_OnChange_25, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_SWAMP_MLX_3_ADVANCED_MENUS_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOMANDSOURCEMENUINITIALIZED__DigitalInput__ = 0;
const uint SOURCELISTHASONEITEM__DigitalInput__ = 1;
const uint REFRESHOPTIONSMENU__DigitalInput__ = 2;
const uint ROOMISON__DigitalInput__ = 3;
const uint HASSOURCES__DigitalInput__ = 4;
const uint SOURCESHAREAVAILABLE__DigitalInput__ = 5;
const uint HASROOMS__DigitalInput__ = 6;
const uint HASSLEEP__DigitalInput__ = 7;
const uint HASGROUPS__DigitalInput__ = 8;
const uint TOOLSMENUENABLED__DigitalInput__ = 9;
const uint GROUPSMENUENABLED__DigitalInput__ = 10;
const uint SLEEPISON__DigitalInput__ = 11;
const uint SLEEPISOFF__DigitalInput__ = 12;
const uint SLEEPWARNINGACTIVATED__DigitalInput__ = 13;
const uint SLEEPWARNINGISACTIVE__DigitalInput__ = 14;
const uint LOUDNESSISON__DigitalInput__ = 15;
const uint LOUDNESSISOFF__DigitalInput__ = 16;
const uint ONSLEEPPAGE__DigitalInput__ = 17;
const uint ONTOOLSPAGE__DigitalInput__ = 18;
const uint SLEEPSELECTBUTTON__DigitalInput__ = 19;
const uint TOOLSSELECTBUTTON__DigitalInput__ = 20;
const uint SLEEPBACKBUTTON__DigitalInput__ = 21;
const uint TOOLSBACKBUTTON__DigitalInput__ = 22;
const uint SINGLESOURCE__AnalogSerialInput__ = 0;
const uint ACTIVESOURCE__AnalogSerialInput__ = 1;
const uint SLEEPTIME__AnalogSerialInput__ = 2;
const uint BASS_DB__AnalogSerialInput__ = 3;
const uint TREBLE_DB__AnalogSerialInput__ = 4;
const uint EQPRESET__AnalogSerialInput__ = 5;
const uint BALANCE__AnalogSerialInput__ = 6;
const uint SINGLESOURCEICON__AnalogSerialInput__ = 7;
const uint ACTIVESOURCEICON__AnalogSerialInput__ = 8;
const uint SINGLESOURCENAME__AnalogSerialInput__ = 9;
const uint ACTIVESOURCENAME__DOLLAR____AnalogSerialInput__ = 10;
const uint GROUPSCONFIGURED__DigitalInput__ = 23;
const uint GROUPSACTIVE__DigitalInput__ = 29;
const uint OPTIONSLINESELECTED__DigitalInput__ = 35;
const uint SLEEPLINESELECTED__DigitalInput__ = 42;
const uint TOOLSLINESELECTED__DigitalInput__ = 44;
const uint GROUPSLINESELECTED__DigitalInput__ = 49;
const uint GROUPSNAMES__AnalogSerialInput__ = 11;
const uint GOTOAUDIOMENUPAGE__DigitalOutput__ = 0;
const uint GOTOSOURCESPAGE__DigitalOutput__ = 1;
const uint GOTOSOURCESHARINGPAGE__DigitalOutput__ = 2;
const uint GOTOROOMSPAGE__DigitalOutput__ = 3;
const uint GOTOSLEEPPAGE__DigitalOutput__ = 4;
const uint GOTOTOOLSPAGE__DigitalOutput__ = 5;
const uint GOTOGROUPSPAGE__DigitalOutput__ = 6;
const uint SLEEPTIMEADJUSTACTIVE__DigitalOutput__ = 7;
const uint SLEEPENABLEADJUSTACTIVE__DigitalOutput__ = 8;
const uint BASSADJUSTACTIVE__DigitalOutput__ = 9;
const uint TREBLEADJUSTACTIVE__DigitalOutput__ = 10;
const uint EQPRESETADJUSTACTIVE__DigitalOutput__ = 11;
const uint BALANCEADJUSTACTIVE__DigitalOutput__ = 12;
const uint LOUDNESSADJUSTACTIVE__DigitalOutput__ = 13;
const uint SELECTSINGLESOURCE__DigitalOutput__ = 14;
const uint SHIFTOPTIONSHIGHLIGHTTOTOP__DigitalOutput__ = 15;
const uint OPTIONSHIGHLIGHTOUT__AnalogSerialOutput__ = 0;
const uint OPTIONSITEMCOUNTOUT__AnalogSerialOutput__ = 1;
const uint SLEEPITEMCOUNTOUT__AnalogSerialOutput__ = 2;
const uint TOOLSITEMCOUNTOUT__AnalogSerialOutput__ = 3;
const uint GROUPSITEMCOUNTOUT__AnalogSerialOutput__ = 4;
const uint OPTIONSLABEL__DOLLAR____AnalogSerialOutput__ = 5;
const uint SLEEPLABEL__DOLLAR____AnalogSerialOutput__ = 6;
const uint TOOLSLABEL__DOLLAR____AnalogSerialOutput__ = 7;
const uint GROUPSLABEL__DOLLAR____AnalogSerialOutput__ = 8;
const uint SLEEPWARNINGMESSAGE__AnalogSerialOutput__ = 9;
const uint TOGGLEGROUPS__DigitalOutput__ = 16;
const uint GOTOSOURCECONTROLPAGE__DigitalOutput__ = 22;
const uint OPTIONSITEMSACTIVE__DigitalOutput__ = 46;
const uint SLEEPITEMSACTIVE__DigitalOutput__ = 53;
const uint TOOLSITEMSACTIVE__DigitalOutput__ = 55;
const uint OPTIONSICONSOUT__AnalogSerialOutput__ = 10;
const uint GROUPSICONSOUT__AnalogSerialOutput__ = 17;
const uint OPTIONSITEMS__DOLLAR____AnalogSerialOutput__ = 23;
const uint SLEEPITEMS__DOLLAR____AnalogSerialOutput__ = 30;
const uint TOOLSITEMS__DOLLAR____AnalogSerialOutput__ = 32;
const uint GROUPSITEMS__DOLLAR____AnalogSerialOutput__ = 37;

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
