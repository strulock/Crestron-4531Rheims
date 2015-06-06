namespace AMFM_Tuner;
        // class declarations
         class AmFmSystem;
         class AmFmTransport;
         class AmFmList;
     class AmFmSystem 
    {
        // class delegates
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );

        // class events

        // class functions
        FUNCTION Initialize ( INTEGER port , INTEGER adapterID , AmFmTransport transportObj , AmFmList listObj );
        FUNCTION ToClient ( STRING data );
        FUNCTION FromClient ( STRING data );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateFnString d_ToClient;
    };

     class AmFmTransport 
    {
        // class delegates
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );
        delegate FUNCTION DelegateFn2Strings ( SIMPLSHARPSTRING myString1 , SIMPLSHARPSTRING myString2 );
        delegate FUNCTION DelegateFnNoParams ( );
        delegate FUNCTION DelegateFnInt ( SIGNED_LONG_INTEGER myInt );
        delegate FUNCTION DelegateFnIntStringInt ( SIGNED_LONG_INTEGER OneInt , SIMPLSHARPSTRING OneString , SIGNED_LONG_INTEGER TwoInt );

        // class events

        // class functions
        FUNCTION Initialize ( SIGNED_LONG_INTEGER psSize , SIGNED_LONG_INTEGER asSize , SIGNED_LONG_INTEGER aaSize , SIGNED_LONG_INTEGER tlSize , SIGNED_LONG_INTEGER bSize );
        FUNCTION ClearDictionary ();
        FUNCTION SetMetaData ( SIGNED_LONG_INTEGER i , STRING s );
        FUNCTION SetProviders ( SIGNED_LONG_INTEGER i , STRING s );
        FUNCTION TriggerStateChangedEvent ();
        FUNCTION SetButtonCount ( SIGNED_LONG_INTEGER c );
        FUNCTION SetStatusMsgItems ( SIGNED_LONG_INTEGER i , STRING s );
        FUNCTION _TriggerStatusMsgEvent ( STRING text , SIGNED_LONG_INTEGER timeOutSec , STRING userInputRequired , STRING initialUserInput , SIGNED_LONG_INTEGER ishow , SIGNED_LONG_INTEGER ilocalExit );
        FUNCTION _TriggerBusyEvent ( SIGNED_LONG_INTEGER ion , SIGNED_LONG_INTEGER timeoutSec );
        FUNCTION TriggerStateChangedByBrowseContextEvent ( SIGNED_LONG_INTEGER instance );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING Name[];
        STRING AmFmListName[];

        // class properties
        DelegateProperty DelegateFnString d_BandSelect;
        DelegateProperty DelegateFn2Strings d_DirectTune;
        DelegateProperty DelegateFnNoParams d_TuneUp;
        DelegateProperty DelegateFnNoParams d_TuneDown;
        DelegateProperty DelegateFnNoParams d_ScanUp;
        DelegateProperty DelegateFnNoParams d_ScanDown;
        DelegateProperty DelegateFnInt d_CyclePreset;
        DelegateProperty DelegateFnInt d_SavePreset;
        DelegateProperty DelegateFnInt d_RecallPreset;
        DelegateProperty DelegateFnInt d_ClearPreset;
        DelegateProperty DelegateFnIntStringInt d_StatusMsgResponse;
        SIGNED_LONG_INTEGER RewindSpeed;
        SIGNED_LONG_INTEGER FfwdSpeed;
        STRING PlayerState[];
        STRING Title[];
        STRING Artist[];
        STRING Album[];
        STRING Genre[];
        STRING Composer[];
        STRING AlbumArtUrl[];
        STRING StationName[];
        SIGNED_LONG_INTEGER ElapsedSec;
        SIGNED_LONG_INTEGER TrackSec;
        SIGNED_LONG_INTEGER TrackNum;
        SIGNED_LONG_INTEGER TrackCnt;
        STRING NextTitle[];
        SIGNED_LONG_INTEGER ShuffleState;
        SIGNED_LONG_INTEGER RepeatState;
        STRING PlayerIconURL[];
        SIGNED_LONG_INTEGER Version;
        SIGNED_LONG_INTEGER Instance;
        STRING Language[];
        STRING ActionsSupported[][];
        STRING ActionsAvailable[][];
        STRING PropertiesSupported[][];
        STRING ProviderName[];
        SIGNED_LONG_INTEGER PlayerIcon;
        STRING PlayerName[];
        STRING StreamState[];
        STRING MediaType[];
        STRING TextLines[][];
        STRING Band[][];
    };

     class AmFmList 
    {
        // class delegates
        delegate FUNCTION DelegateFnInt ( SIGNED_LONG_INTEGER myInt );
        delegate FUNCTION DelegateFn2Ints ( SIGNED_LONG_INTEGER myInt1 , SIGNED_LONG_INTEGER myInt2 );
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );

        // class events

        // class functions
        FUNCTION Initialize ( SIGNED_LONG_INTEGER fsSize , SIGNED_LONG_INTEGER lsSize , SIGNED_LONG_INTEGER gdSize );
        FUNCTION ClearDictionary ();
        FUNCTION SetData ( SIGNED_LONG_INTEGER i , STRING s );
        FUNCTION TriggerUpdateEvent ( SIGNED_LONG_INTEGER item , SIGNED_LONG_INTEGER count );
        FUNCTION TriggerClearEvent ();
        FUNCTION _TriggerBusyEvent ( SIGNED_LONG_INTEGER ion , SIGNED_LONG_INTEGER timeoutSec );
        FUNCTION TriggerStateChangedEvent ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING Name[];

        // class properties
        DelegateProperty DelegateFnInt d_Select;
        DelegateProperty DelegateFnInt d_PressAndHold;
        DelegateProperty DelegateFn2Ints d_GetData;
        DelegateProperty DelegateFnString d_KeypadInput;
        SIGNED_LONG_INTEGER Version;
        SIGNED_LONG_INTEGER Instance;
        STRING Language[];
        STRING Title[];
        SIGNED_LONG_INTEGER ItemCnt;
        STRING FindDesired[];
        STRING FindSupported[][];
        SIGNED_LONG_INTEGER Level;
        STRING Sorted[];
        SIGNED_LONG_INTEGER MaxReqItems;
        STRING ListSpecificFunctions[][];
        STRING ActionsSupported[][];
        STRING ActionsAvailable[][];
        STRING Subtitle[];
    };

