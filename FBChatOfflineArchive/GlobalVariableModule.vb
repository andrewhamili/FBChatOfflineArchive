Imports MySql.Data.MySqlClient
Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;username=root;password=root;"
    Public reader As MySqlDataReader
    Public comm As New MySqlCommand
End Module
