// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

namespace mshtml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3050F7EC-98B5-11CF-BB82-00AA00BDCE0B"), TypeLibType((short) 0x1040)]
    public interface IHTMLSelectionObject2
    {
        [return: MarshalAs(UnmanagedType.IDispatch)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3ed)]
        object createRangeCollection();
        [DispId(0x3ee)]
        string typeDetail { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3ee)] get; }
    }
}

