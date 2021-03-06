﻿using System;
using System.IO;

namespace Trinet.Core.IO.Ntfs
{
	internal static class Resources
	{
		// HACK: "dotnet build" doesn't support ResX files when targetting .NET 3.5
		// https://github.com/Microsoft/msbuild/issues/1333
		// https://github.com/Microsoft/msbuild/issues/2272

        public static string Error_AccessDenied_Path(string path) {return "Access to the path '" + path+ "' was denied.";}
        public static string Error_AlreadyExists(string path) {return "Cannot create '" + path+ "' because a file or directory with the same name already exists.";}
        public static string Error_DirectoryNotFound(string path) {return "Could not find a part of the path '" + path+ "'.";}
        public static string Error_DriveNotFound(string path) {return "Could not find the drive '" + path+ "'. The drive might not be ready or might not be mapped.";}
        public static string Error_FileAlreadyExists(string path) {return"The file '" + path+ "' already exists.";}
        public static string Error_InvalidFileChars() { return "The specified stream name contains invalid characters.";}
        public static string Error_InvalidMode(FileMode mode) {return "The specified mode '" + mode+ "' is not supported.";}
        public static string Error_NonFile(string path) {return "The specified file name '" + path+ "' is not a disk-based file.";}
        public static string Error_SharingViolation(string path) {return "The process cannot access the file '" + path+ "' because it is being used by another process.";}
        public static string Error_StreamExists(string streamName, string path) {return "The specified alternate data stream '" + streamName+ "' already exists on file '" + path+ "'.";}
        public static string Error_StreamNotFound(string streamName, string path) {return "The specified alternate data stream '" + streamName+ "' does not exist on file '" + path+ "'.";}
        public static string Error_UnknownError(int errorCode) {return "Unknown error: "+ errorCode.ToString();}
	}
}