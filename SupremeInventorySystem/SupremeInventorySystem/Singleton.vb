Public Class Singleton

    Public Shared ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\bookhub.mdb")

    Public Shared Property SessionID As Integer
    Public Shared Property FullName As String
    Public Shared Property Privilege As String

End Class
