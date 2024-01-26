Imports MySql.Data.MySqlClient

Module Thesis_Connection

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet

    Public Sub cleartxt()

        Fregister.txtStudentID.Clear()
        Fregister.txtStudentName.Clear()
        Fregister.txtSection.Clear()
        Fregister.txtEmergency.Clear()
        Fregister.txtEmail.Clear()

    End Sub

    Public Sub insert(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    'MessageBox.Show("Failed to insert", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cleartxt()
                strcon.Close()
                    da.Dispose()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub


    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            strcon.Open()

            dt = New DataTable
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.Datasource = dt
            strcon.Close()
            da.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery

                'If result = 0 Then
                ' MessageBox.Show("Failed to update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Else
                ' MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cleartxt()

                'End If

            End With

        Catch ex As Exception
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub reloadTxt(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
            strcon.Close()
            da.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Module
