Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Runtime.Serialization.Json
Imports System.IO
Imports System.Text

Module ServersUtils
    Public Function Save(SrwList As System.Collections.Specialized.StringCollection) As String
        Dim ser As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(System.Collections.Specialized.StringCollection))
        Dim ms As MemoryStream = New MemoryStream()
        ser.WriteObject(ms, SrwList)
        Dim jsonString As String = Encoding.UTF8.GetString(ms.ToArray())
        ms.Close()
        Return jsonString
    End Function
    Public Function Load(JsonString As String) As System.Collections.Specialized.StringCollection
        Dim ser As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(System.Collections.Specialized.StringCollection))
        Dim ms As MemoryStream = New MemoryStream(Encoding.UTF8.GetBytes(JsonString))
        Dim obj As System.Collections.Specialized.StringCollection = ser.ReadObject(ms)
        Return obj
    End Function
    Public Function OldFormatToNew(Addres As String, name As String)
        Dim res As String()
        Dim neew As New System.Collections.Specialized.StringCollection
        res = Addres.Split(":")
        neew.Add(name)
        neew.Add(res(0))
        neew.Add(res(1))
        Return neew
    End Function
End Module
