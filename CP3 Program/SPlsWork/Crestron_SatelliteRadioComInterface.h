namespace Crestron.SatelliteRadioComInterface;
        // class declarations
         class SiriusXMHWInterface;
         class SiriusXMUIInterface;
     class SiriusXMHWInterface 
    {
        // class delegates
        delegate SIMPLSHARPSTRING_FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );

        // class events

        // class functions
        LONG_INTEGER_FUNCTION Register ( SIGNED_LONG_INTEGER id );
        SIMPLSHARPSTRING_FUNCTION GuideRequest ( SIMPLSHARPSTRING request );
        FUNCTION SendGlobalUpdate ( SIMPLSHARPSTRING guideinfo );
        FUNCTION SendMessage ( SIGNED_LONG_INTEGER deviceid , SIMPLSHARPSTRING message );
        FUNCTION SendPresetUpdateEvent ( SIMPLSHARPSTRING message );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER EquipID;

        // class properties
        DelegateProperty DelegateFnString GuideRequestSplus;
    };

     class SiriusXMUIInterface 
    {
        // class delegates
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );

        // class events

        // class functions
        LONG_INTEGER_FUNCTION Register ( SIGNED_LONG_INTEGER id );
        LONG_INTEGER_FUNCTION Connect ( SIGNED_LONG_INTEGER id );
        FUNCTION ReceiveServerMessage ( SIMPLSHARPSTRING message );
        FUNCTION SendGuideRequest ( STRING request );
        FUNCTION AddPresetUpdateListener ();
        FUNCTION RemovePresetUpdateListener ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        Crestron.SatelliteRadioComInterface.SiriusXMHWInterface Server;

        // class properties
        DelegateProperty DelegateFnString GuideResponseSplus;
    };

