﻿Imports MySql.Data.MySqlClient
Module DB_Connection
    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root; Password=; Database=thesis_db; sslmode=none; Convert Zero DateTime=true;")
    End Function

    Public strcon As MySqlConnection = strstrconnection()

End Module
