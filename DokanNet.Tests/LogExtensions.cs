﻿namespace DokanNet.Tests
{
    internal static class LogExtensions
    {
        public static string Log(this DokanFileInfo info)
            =>
                $"{nameof(DokanFileInfo)} {{{info.Context ?? "<null>"}, {(info.DeleteOnClose ? nameof(info.DeleteOnClose) : "")}, {(info.IsDirectory ? nameof(info.IsDirectory) : "")}, {(info.NoCache ? nameof(info.NoCache) : "")}, {(info.PagingIo ? nameof(info.PagingIo) : "")}, {info.ProcessId}, {(info.SynchronousIo ? nameof(info.SynchronousIo) : "")}, {(info.WriteToEndOfFile ? nameof(info.WriteToEndOfFile) : "")}}}";

        public static string Log(this FileInformation fileInfo)
            =>
                $"{nameof(FileInformation)} {{{fileInfo.FileName}, [{fileInfo.Attributes}], {(fileInfo.CreationTime.HasValue ? fileInfo.CreationTime.Value.ToString() : "<null>")}, {(fileInfo.LastWriteTime.HasValue ? fileInfo.LastWriteTime.Value.ToString() : "<null>")}, {(fileInfo.LastAccessTime.HasValue ? fileInfo.LastAccessTime.Value.ToString() : "<null>")}, {fileInfo.Length}}}";
    }
}