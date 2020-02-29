# aspnet-dump-analysis-sample
asp.net dump analizi ornek site

# Kurulum

## Dump alma

```
adplus.exe -p [processId] -hang -o c:\dumps
```

## Windbg

```
.symfix
.reload
.loadby sos clr
```

### Exception

```
~*e !clrstack
!threads
!pe 000000033f621188
!runaway 1
```

### Memory Analiz

```
!dumpheap -stat
!dumpheap -type System.IO.MemoryStream
!do [address]
!do [object address]
!gcroot [address to object]
```
