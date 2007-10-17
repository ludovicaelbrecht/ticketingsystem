Imports System.data.sqlclient
Imports System.data


Namespace css



Public Class clsdatabase
    Public Shared Function openConn(ByVal sqlstring As String)
        Dim rs2, objConn

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=localhost;			DATABASE=css; UID=root; PASSWORD=admin") ' Parentheses			added.
        rs2 = objConn.execute(sqlstring) ' Set statement removed.
        Return rs2
        rs2.close()
        rs2 = Nothing ' Set statement removed.
        objConn.close()
    End Function
    Public Shared Sub sqlupdate(ByVal sqlstring As String)
        Dim objConn

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=bnc.rope.be;			DATABASE=batilink; UID=batilink; PASSWORD=batilink") ' Parentheses added.
        objConn.execute(sqlstring) ' Set statement removed.
        objConn.close()
    End Sub
    Public Shared Sub sqlinsert(ByVal sqlstring As String)
        Dim objConn

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=bnc.rope.be;			DATABASE=batilink; UID=batilink; PASSWORD=batilink") ' Parentheses added.
        objConn.execute(sqlstring) ' Set statement removed.
        objConn.close()
    End Sub
    Public Shared Sub sqldelete(ByVal sqlstring As String)
        Dim objConn

        objConn = CreateObject("ADODB.Connection") ' Set removed.
        objConn.Open("Driver={MySQL ODBC 3.51 Driver}; SERVER=bnc.rope.be;			DATABASE=batilink; UID=batilink; PASSWORD=batilink") ' Parentheses added.
        objConn.execute(sqlstring) ' Set statement removed.
        objConn.close()
    End Sub
    

End Class

End Namespace

