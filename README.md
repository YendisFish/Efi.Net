# Efi.Net
Efi.Net is a .Net 7 oriented library wrapping the
UEFI API. This project utilizes C#s <a href="https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/">NativeAOT</a>
features to allow C# to run as a self contained
UEFI application.

## What is this project for?
With the recent release of C#'s <a href="https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/">NativeAOT</a> features
I immediately wondered: Can C# be used to make an operating system?
I still do not know the answer to this question, however, this project
is one of the stepping stones on my never ending quest to try and
force C# to run as a full fledged OS. And by stepping stone I mean
I have tried many many different things.

## Inspiration
Efi.Net is a descendant of many different ideas and libraries, however,
there are 2 main repositories that this project is based off of. I
would like to give credit to them:

 - <a href="https://github.com/JoshuaWierenga/EfiSharp">EfiSharp</a>
 - <a href="https://github.com/MichalStrehovsky/zerosharp">Zerosharp</a>

Both of these repositories have been wonderful references while writing
this project and I would like to thank their creators!

## Who is this for?
This is mainly for <a href="https://thcotd.org">my organization</a> and
their internal project <a href="https://github.com/The-Holy-Church-of-Terry-Davis/divinityC-x86_64">Divinity</a>.
However, anyone looking to port C# to some UEFI interface has also
probably found what they want here. (assuming this works. At the time of writing the readme I have not yet tested the library!)