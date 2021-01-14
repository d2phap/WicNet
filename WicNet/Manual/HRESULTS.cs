﻿namespace WicNet
{
    public enum HRESULTS
    {
        S_OK = 0,
        S_FALSE = 1,
        E_FAIL = unchecked((int)0x80004005),
        E_NOINTERFACE = unchecked((int)0x80004002),
        E_INVALIDARG = unchecked((int)0x80070057),
        E_ACCESSDENIED = unchecked((int)0x80070005),
        E_NOTIMPL = unchecked((int)0x80004001),
        E_NOT_VALID_STATE = unchecked((int)0x8007139F),
        E_UNEXPECTED = unchecked((int)0x8000FFFF),
        E_NOT_SUFFICIENT_BUFFER = unchecked((int)0x8007007A),
        E_BOUNDS = unchecked((int)0x8000000B),
        ERROR_CANCELLED = unchecked((int)0x800704C7),
        ERROR_INTERNAL_ERROR = unchecked((int)0x8007054F),
        ERROR_INVALID_DATA = unchecked((int)0x8007000D),
        ERROR_INVALID_OPERATION = unchecked((int)0x800710DD),
        ERROR_INVALID_NAME = unchecked((int)0x8007007B),
        ERROR_INVALID_HANDLE = unchecked((int)0x80070006),
        DISP_E_EXCEPTION = unchecked((int)0x80020009),

        // wic
        WINCODEC_ERR_WRONGSTATE = unchecked((int)0x88982f04),
        WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)0x88982f05),
        WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)0x88982f07),
        WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)0x88982f0B),
        WINCODEC_ERR_NOTINITIALIZED = unchecked((int)0x88982f0C),
        WINCODEC_ERR_ALREADYLOCKED = unchecked((int)0x88982f0D),
        WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)0x88982f40),
        WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)0x88982f41),
        WINCODEC_ERR_PROPERTYSIZE = unchecked((int)0x88982f42),
        WINCODEC_ERR_CODECPRESENT = unchecked((int)0x88982f43),
        WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)0x88982f44),
        WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)0x88982f45),
        WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)0x88982f46),
        WINCODEC_ERR_INTERNALERROR = unchecked((int)0x88982f48),
        WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)0x88982f49),
        WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)0x88982f50),
        WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)0x88982f51),
        WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)0x88982f52),
        WINCODEC_ERR_BADIMAGE = unchecked((int)0x88982f60),
        WINCODEC_ERR_BADHEADER = unchecked((int)0x88982f61),
        WINCODEC_ERR_FRAMEMISSING = unchecked((int)0x88982f62),
        WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)0x88982f63),
        WINCODEC_ERR_BADSTREAMDATA = unchecked((int)0x88982f70),
        WINCODEC_ERR_STREAMWRITE = unchecked((int)0x88982f71),
        WINCODEC_ERR_STREAMREAD = unchecked((int)0x88982f72),
        WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)0x88982f73),
        WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)0x88982f80),
        WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982f81),
        WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)0x88982f8A),
        WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)0x88982f8B),
        WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)0x88982f8C),
        WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)0x88982f8D),
        WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)0x88982f8E),
        WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)0x88982f8F),
        WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)0x88982f90),
        WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)0x88982f91),
        WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)0x88982f92),
        WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)0x88982f93),
        WINCODEC_ERR_WIN32ERROR = unchecked((int)0x88982f94),
        WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)0x88982f95),
        WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)0x88982F96),
    }
}
