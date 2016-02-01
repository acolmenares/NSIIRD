Imports Microsoft.VisualBasic
Imports System.Guid
Imports System.Data

Public Class Test
    Shared Function Investigar(ByVal txtdocumento As String) As String
        ' Use the 'client' variable to call operations on the service.
        Dim client As WSUnidad.ConsultaClient = New WSUnidad.ConsultaClient()

        Dim parametros As New WSUnidad.ParametrosEntradaVictimaPorDocumento
        Dim salidas As New WSUnidad.ParametrosSalidaVictima
        Dim id As New System.Guid("01B2106A-9F9B-493B-8BEE-23750E51BDA9")
        parametros.Token = id
        parametros.NumeroDocumento = txtdocumento

        salidas = client.ConsultarVictima(parametros)

        'Dim ResultConsulta As WSUnidad.ResultadoConsulta
        Dim AAA(26) As Object
        AAA = salidas.VictimaRUV
        Dim LABEL1 As New Label
        LABEL1.Text = AAA(1)

        Return LABEL1.Text



        ' Always close the client.
        client.Close()
    End Function
End Class

