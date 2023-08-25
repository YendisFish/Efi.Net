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

## How to use
Sooo.... I could not figure out a good way to reference this library
from a C# project. The reason for this is that to run C# in UEFI (the zerosharp way)
you need to strip all the assembly references that dotnet generates
from the project. So you will have to copy the entirety of the library
into your project. I am working on finding a fix! but as of now I
have not found one.

You will need these files to run the official library features:

- Efi.Net/System/
- Efi.Net/UEFI/
- Efi.Net/ZerosharpCopy.cs

Now if you want the additional experimental features you can copy
over the experimental directory:

- Efi.Net/Experimental

You will also need to make sure your C# Project file is configured
correctly. I suggest taking some inspiration from <a href="https://github.com/MichalStrehovsky/zerosharp">Zerosharp</a> here.

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

## Todo
List of features I would like to test/add in the future.

- [ ] Start on/complete EfiBootServices class
- [ ] Expand KernelCallHost class to include other important funcs and values
- [ ] I/O wrapper (System.Console)
- [ ] JSON serializer/deserializer (EfiNet.JSON)