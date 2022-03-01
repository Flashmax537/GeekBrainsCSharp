
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly CheckForChange
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0E 43 68 65 63 6B 46 6F 72 43 68 61 6E 67   // ...CheckForChang
                                                                                              65 00 00 )                                        // e..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0E 43 68 65 63 6B 46 6F 72 43 68 61 6E 67   // ...CheckForChang
                                                                                                65 00 00 )                                        // e..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 34 36 36 61 33 65 39 31 2D 36 36 63 39   // ..$466a3e91-66c9
                                                                                                  2D 34 37 62 39 2D 62 61 32 62 2D 65 64 32 62 65   // -47b9-ba2b-ed2be
                                                                                                  34 30 61 39 37 64 39 00 00 )                      // 40a97d9..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CheckForChange.exe
// MVID: {E0B81F64-31B9-4589-9F84-C55C0BB4EDAA}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x0B9A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit CheckForChange.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Размер кода:       37 (0x25)
    .maxstack  1
    .locals init ([0] bool isChanged,
             [1] bool V_1)
    IL_0000:  nop
    IL_0001:  ldc.i4.0
    IL_0002:  stloc.0
    IL_0003:  ldloc.0
    IL_0004:  stloc.1
    IL_0005:  ldloc.1
    IL_0006:  brtrue.s  IL_0017

    IL_0008:  nop
    IL_0009:  ldstr      bytearray (1A 04 3E 04 34 04 20 00 38 04 37 04 3C 04 35 04   // ..>.4. .8.7.<.5.
                                    3D 04 35 04 3D 04 20 00 41 04 20 00 3F 04 3E 04   // =.5.=.!.
									3C 04 3E 04 49 04 4C 04 4E 04 20 00 22 00 69 00 
									6C 00 64 00 61 00 73 00 6D 00 2F 00 69 00 6C 00 
									61 00 73 00 6D 00 22 00 21 00 ) 
    IL_000e:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0013:  nop
    IL_0014:  nop
    IL_0015:  br.s       IL_0024

    IL_0017:  nop
    IL_0018:  ldstr      bytearray (1A 04 3E 04 34 04 20 00 3D 04 35 04 20 00 38 04   // ..>.4. .=.5. .8.
                                    37 04 3C 04 35 04 3D 04 35 04 3D 04 21 00 )       // 7.<.5.=.5.=.!.
    IL_001d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0022:  nop
    IL_0023:  nop
    IL_0024:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class CheckForChange.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\GeekBrains\GeekBrainsCSharp\lesson7Task2\CheckForChange_ilasm.res
