Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Guid

Public Class Class1
    Shared Function ConsultaIncluido(ByVal txtdocumento As String) As String
        ' Use the 'client' variable to call operations on the service.
        Dim client As WSUnidad1.ConsultaClient = New WSUnidad1.ConsultaClient()
        Dim salidas As New WSUnidad1.ParametrosSalidaVictima
        Dim wcadena As String = "No Hay dato."


        Try
            Dim parametros As New WSUnidad1.ParametrosEntradaVictimaPorDocumento
            Dim id As New System.Guid("01B2106A-9F9B-493B-8BEE-23750E51BDA9")
            parametros.Token = id
            parametros.NumeroDocumento = txtdocumento

            salidas = client.ConsultarVictima(parametros)

            For i = 0 To salidas.VictimaRUV.Length - 1
                If salidas.VictimaRUV(i).hechoVictimizante = "Desplazamiento forzado" Then
                    If (salidas.VictimaRUV(i).fechaDeclaracion >= "01/Aug/2014") Then
                        wcadena = salidas.VictimaRUV(i).estadoValoracion & "-Fecha : " & salidas.VictimaRUV(i).fechaValoracion

                    End If

                End If
            Next
            ''ricardo
            For i = 0 To salidas.VictimaSIPOD.Length - 1
                If salidas.VictimaSIPOD(i).hechoVictimizante = "Desplazamiento forzado" Then
                    If (salidas.VictimaSIPOD(i).fechaDeclaracion > "01/Aug/2014") Then
                        wcadena = salidas.VictimaSIPOD(i).estadoValoracion & "-Fecha : " & salidas.VictimaRUV(i).fechaValoracion

                    End If

                End If
            Next

        Catch ex As Exception

        End Try
        Return wcadena
        ' Always close the client.
        client.Close()
    End Function


    Shared Function ConsultaTodos(ByVal txtdocumento As String) As DataSet
        ' Use the 'client' variable to call operations on the service.
        Dim client As WSUnidad1.ConsultaClient = New WSUnidad1.ConsultaClient()
        Dim salidas As New WSUnidad1.ParametrosSalidaVictima
        Dim DS As New DataSet

        Try

            Dim parametros As New WSUnidad1.ParametrosEntradaVictimaPorDocumento
            Dim id As New System.Guid("01B2106A-9F9B-493B-8BEE-23750E51BDA9")
            parametros.Token = id
            parametros.NumeroDocumento = txtdocumento
            salidas = client.ConsultarVictima(parametros)

            Dim tablaruv As New DataTable
            Dim dr As DataRow

            Dim newcol As New DataColumn
            newcol.ColumnName = "Entidad"
            newcol.DataType = Type.GetType("System.String")
            tablaruv.Columns.Add(newcol)

            newcol = New DataColumn
            newcol.ColumnName = "Estado"
            newcol.DataType = Type.GetType("System.String")
            tablaruv.Columns.Add(newcol)

            newcol = New DataColumn
            newcol.ColumnName = "Fecha_Valoracion"
            newcol.DataType = Type.GetType("System.String")
            tablaruv.Columns.Add(newcol)
            For i = 0 To salidas.VictimaRUV.Length - 1
                If salidas.VictimaRUV(i).hechoVictimizante = "Desplazamiento forzado" Then
                    If (salidas.VictimaRUV(i).fechaDeclaracion > "01/Aug/2014") Then


                        dr = tablaruv.NewRow()
                        dr("Entidad") = "RUV"
                        dr("Estado") = salidas.VictimaRUV(i).estadoValoracion
                        dr("Fecha_Valoracion") = salidas.VictimaRUV(i).fechaValoracion
                        tablaruv.Rows.Add(dr)

                    End If

                End If
            Next

            For i = 0 To salidas.VictimaSIPOD.Length - 1
                If salidas.VictimaSIPOD(i).hechoVictimizante = "Desplazamiento forzado" Then
                    If (salidas.VictimaSIPOD(i).fechaDeclaracion > "01/Aug/2014") Then
                        dr = tablaruv.NewRow()
                        dr("Entidad") = "SIPOD"
                        dr("Estado") = salidas.VictimaSIPOD(i).estadoValoracion
                        dr("Fecha_Valoracion") = salidas.VictimaSIPOD(i).fechaValoracion
                        tablaruv.Rows.Add(dr)

                    End If

                End If
            Next

            DS.Tables.Add(tablaruv)


        Catch ex As Exception

        End Try


        Return DS
        ' Always close the client.
        client.Close()
    End Function
End Class
