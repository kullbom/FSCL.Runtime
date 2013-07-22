﻿namespace FSCL.Runtime

type KernelCompilationException(msg: string) =
    inherit System.Exception(msg)
    
type KernelTargetCodeGenerationException(msg: string) =
    inherit System.Exception(msg)
    
type KernelDeviceSelectionException(msg: string) =
    inherit System.Exception(msg)

