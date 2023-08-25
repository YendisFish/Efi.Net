using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public enum EfiStatus : uint
{
    EFI_SUCCESS = 0,
    EFI_LOAD_ERROR,
    EFI_INVALID_PARAMETER,
    EFI_UNSUPPORTED,
    EFI_BAD_BUFFER_SIZE,
    EFI_BUFFER_TOO_SMALL,
    EFI_NOT_READY,
    EFI_DEVICE_ERROR,
    EFI_WRITE_PROTECTED,
    EFI_OUT_OF_RESOURCES,
    EFI_VOLUME_CORRUPTED,
    EFI_VOLUME_FULL,
    EFI_NO_MEDIA,
    EFI_MEDIA_CHANGED,
    EFI_NOT_FOUND,
    EFI_ACCESS_DENIED,
    EFI_NO_RESPONSE,
    EFI_NO_MAPPING,
    EFI_TIMEOUT,
    EFI_NOT_STARTED,
    EFI_ALREADY_STARTED,
    EFI_ABORTED,
    EFI_ICMP_ERROR,
    EFI_TFTP_ERROR,
    EFI_PROTOCOL_ERROR,
    EFI_INCOMPATIBLE_VERSION,
    EFI_SECURITY_VIOLATION,
    EFI_CRC_ERROR,
    EFI_END_OF_MEDIA,
    EFI_END_OF_FILE,
    EFI_INVALID_LANGUAGE,
    EFI_COMPROMISED_DATA,
    EFI_IP_ADDRESS_CONFLICT,
    EFI_HTTP_ERROR,
    EFI_UNKNOWN_ERROR
}