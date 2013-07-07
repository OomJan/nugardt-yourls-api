﻿' NuGardt YOURLS API
' Copyright (C) 2013 NuGardt Software
' http://www.nugardt.com
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports System.Runtime.Serialization

Namespace Yourls.API.Result
  ''' <summary>
  ''' YOURLS API response.
  ''' </summary>
  ''' <remarks></remarks>
  <DataContract()>
  Public Class YourlsExpandShortUrlResult
    Inherits YourlsResult

    'SUCESS
    '{
    '"keyword":"2go8s",
    '"shorturl":"http:\/\/ls.nugardt.com\/2go8s",
    '"longurl":"http:\/\/www.nugardt.com",
    '"message":"success",
    '"statusCode":200
    '}

    'ERROR
    '{
    '"message":"Invalid username or password",
    '"errorCode":403,
    '"callback":""
    '}

    ''' <summary>
    ''' Returns the keyword of the short link.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name := "keyword")>
    Public Keyword As String

    ''' <summary>
    ''' Returns the short URL.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name := "shorturl")>
    Public ShortUrl As String

    ''' <summary>
    ''' Returns the long URL.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name := "longurl")>
    Public LongUrl As String
  End Class
End Namespace