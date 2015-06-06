namespace CRPCConnectionHelper;
        // class declarations
         class CIPTransportParameters;
         class CRPCConnectionHandler;
         class ModuleLogger;
         class CRPCConnection;
         class EthernetManager;
     class CIPTransportParameters 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CRPCConnectionHandler 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class CRPCConnection 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION OnJoinData ( STRING packet );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class EthernetManager 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

