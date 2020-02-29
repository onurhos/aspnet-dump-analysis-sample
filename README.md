# aspnet-dump-analysis-sample
asp.net dump analizi ornek site

## Presentasyon
https://docs.google.com/presentation/d/1Ce9oqwmRWfnu5JUIMYDFXs9vvX3TSOr3cArA4uIJPTE/edit?usp=sharing

# Kurulum

## Dump alma

```
adplus.exe -p [processId] -hang -o c:\dumps
```

veya

```
procdump -accepteula  -m 200 -ma -64 6968
```

veya

```
Task manager -> Process -> Create Dump File
```

## Windbg

```
.symfix
.reload
.loadby sos clr
```

### Memory Analiz

```
!dumpheap -stat
!dumpheap -type System.IO.MemoryStream
!do [address]
!do [object address]
!gcroot [address to object]
```

# Kaynaklar

## Memory Management
- https://www.jetbrains.com/help/dotmemory/NET_Memory_Management_Concepts.html
- https://www.red-gate.com/simple-talk/dotnet/net-framework/net-memory-management-basics/
- https://www.youtube.com/watch?v=Q2sFmqvpBe0
- https://www.codeproject.com/Articles/76153/Six-important-NET-concepts-Stack-heap-value-types
- https://www.c-sharpcorner.com/UploadFile/26b237/net-memory-management/
- http://net-informations.com/faq/net/stack-heap.htm

## Dump Alma
- https://docs.microsoft.com/en-us/archive/blogs/benjaminperkins/create-a-memory-dump-when-the-w3wp-process-terminates-using-procdump
- https://kb.sitecore.net/articles/253710

## WinDbg

- https://docs.microsoft.com/en-us/sysinternals/downloads/
- https://docs.microsoft.com/en-us/windows-hardware/drivers/download-the-wdk
- http://geekswithblogs.net/.NETonMyMind/archive/2006/03/14/72262.aspx
- https://snede.net/hunting-net-memory-leaks-with-windbg/
- https://stackify.com/using-windbg-to-analyze-net-crash-dumps-async-crash/

## Books
- Under the Hood of .NET Memory Management - https://drive.google.com/file/d/1aWvdwTRuPxBLm8kYsIwAZNKnjD2BW8aB/view
- Dump Analysis / Pamir Erdem : https://b-ok.org/book/3384790/db283e
