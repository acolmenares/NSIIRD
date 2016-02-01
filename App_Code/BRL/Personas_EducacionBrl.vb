Imports ingNovar.Utilidades2
imports system.data
Imports system.collectionS.generic

Partial Public Class Personas_EducacionBrl

    Private _Id As Int32
    Private _Id_Persona As Int32
    Private _Fecha As Object
    Private _Id_Estudia_Actualmente As Int32
    Private _Id_Motivo_NoEstudia As Int32
    Private _Id_Certificado_Matricula As Int32
    Private _Id_Seguimiento As Int32
    Private _Establecimiento As String
    Private _Id_grado_escolar As Int32
    Private _Verificado_Entidad As Int16
    Private _Fecha_Cierre As DateTime
    Private _Cierre As Boolean
    Private _Observaciones As String
    Private _Id_Tipo_Entrega As Int32
    Private _Id_Declaracion_Seguimiento As Int32
    Private _Id_Municipio_Instituto As Int32

    Public Event Creating()
    Public Event Created()

    Public Sub New()
        RaiseEvent Creating()
        'Adicionar código al costructor aquí

        RaiseEvent Created()
    End Sub
    Public Event IDChanging(ByVal Value As Int32)
    Public Event IDChanged()

    Public Property ID() As Int32
        Get
            Return Me._Id
        End Get
        Set(ByVal Value As Int32)
            If _Id <> Value Then
                RaiseEvent IDChanging(Value)
                Me._Id = Value
                RaiseEvent IDChanged()
            End If
        End Set
    End Property

    Public Event Id_PersonaChanging(ByVal Value As Int32)
    Public Event Id_PersonaChanged()

    Public Property Id_Persona() As Int32
        Get
            Return Me._Id_Persona
        End Get
        Set(ByVal Value As Int32)
            If _Id_Persona <> Value Then
                RaiseEvent Id_PersonaChanging(Value)
                Me._Id_Persona = Value
                RaiseEvent Id_PersonaChanged()
            End If
        End Set
    End Property

    Public Event Id_Tipo_EntregaChanging(ByVal Value As Int32)
    Public Event Id_Tipo_EntregaChanged()

    Public Property Id_Tipo_Entrega() As Int32
        Get
            Return Me._Id_Tipo_Entrega
        End Get
        Set(ByVal Value As Int32)
            If _Id_Tipo_Entrega <> Value Then
                RaiseEvent Id_Tipo_EntregaChanging(Value)
                Me._Id_Tipo_Entrega = Value
                RaiseEvent Id_Tipo_EntregaChanged()
            End If
        End Set
    End Property

    Public Event FechaChanging(ByVal Value As Object)
    Public Event FechaChanged()

    Public Property Fecha() As Object
        Get
            Return Me._Fecha
        End Get
        Set(ByVal Value As Object)
            If _Fecha <> Value Then
                RaiseEvent FechaChanging(Value)
                Me._Fecha = Value
                RaiseEvent FechaChanged()
            End If
        End Set
    End Property

    Public Event Id_Estudia_ActualmenteChanging(ByVal Value As Int32)
    Public Event Id_Estudia_ActualmenteChanged()

    Public Property Id_Estudia_Actualmente() As Int32
        Get
            Return Me._Id_Estudia_Actualmente
        End Get
        Set(ByVal Value As Int32)
            If _Id_Estudia_Actualmente <> Value Then
                RaiseEvent Id_Estudia_ActualmenteChanging(Value)
                Me._Id_Estudia_Actualmente = Value
                RaiseEvent Id_Estudia_ActualmenteChanged()
            End If
        End Set
    End Property

    Public Event Id_Motivo_NoEstudiaChanging(ByVal Value As Int32)
    Public Event Id_Motivo_NoEstudiaChanged()

    Public Property Id_Motivo_NoEstudia() As Int32
        Get
            Return Me._Id_Motivo_NoEstudia
        End Get
        Set(ByVal Value As Int32)
            If _Id_Motivo_NoEstudia <> Value Then
                RaiseEvent Id_Motivo_NoEstudiaChanging(Value)
                Me._Id_Motivo_NoEstudia = Value
                RaiseEvent Id_Motivo_NoEstudiaChanged()
            End If
        End Set
    End Property

    Public Event Id_Certificado_MatriculaChanging(ByVal Value As Int32)
    Public Event Id_Certificado_MatriculaChanged()

    Public Property Id_Certificado_Matricula() As Int32
        Get
            Return Me._Id_Certificado_Matricula
        End Get
        Set(ByVal Value As Int32)
            If _Id_Certificado_Matricula <> Value Then
                RaiseEvent Id_Certificado_MatriculaChanging(Value)
                Me._Id_Certificado_Matricula = Value
                RaiseEvent Id_Certificado_MatriculaChanged()
            End If
        End Set
    End Property

    Public Event Id_SeguimientoChanging(ByVal Value As Int32)
    Public Event Id_SeguimientoChanged()

    Public Property Id_Seguimiento() As Int32
        Get
            Return Me._Id_Seguimiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Seguimiento <> Value Then
                RaiseEvent Id_SeguimientoChanging(Value)
                Me._Id_Seguimiento = Value
                RaiseEvent Id_SeguimientoChanged()
            End If
        End Set
    End Property

    Public Event EstablecimientoChanging(ByVal Value As String)
    Public Event EstablecimientoChanged()

    Public Property Establecimiento() As String
        Get
            Return Me._Establecimiento
        End Get
        Set(ByVal Value As String)
            If _Establecimiento <> Value Then
                RaiseEvent EstablecimientoChanging(Value)
                Me._Establecimiento = Value
                RaiseEvent EstablecimientoChanged()
            End If
        End Set
    End Property

    Public Event Id_grado_escolarChanging(ByVal Value As Int32)
    Public Event Id_grado_escolarChanged()

    Public Property Id_grado_escolar() As Int32
        Get
            Return Me._Id_grado_escolar
        End Get
        Set(ByVal Value As Int32)
            If _Id_grado_escolar <> Value Then
                RaiseEvent Id_grado_escolarChanging(Value)
                Me._Id_grado_escolar = Value
                RaiseEvent Id_grado_escolarChanged()
            End If
        End Set
    End Property

    Public Event Verificado_EntidadChanging(ByVal Value As Int32)
    Public Event Verificado_EntidadChanged()

    Public Property Verificado_Entidad() As Int32
        Get
            Return Me._Verificado_Entidad
        End Get
        Set(ByVal Value As Int32)
            If _Verificado_Entidad <> Value Then
                RaiseEvent Verificado_EntidadChanging(Value)
                Me._Verificado_Entidad = Value
                RaiseEvent Verificado_EntidadChanged()
            End If
        End Set
    End Property

    Public Event Fecha_CierreChanging(ByVal Value As DateTime)
    Public Event Fecha_CierreChanged()

    Public Property Fecha_Cierre() As DateTime
        Get
            Return Me._Fecha_Cierre
        End Get
        Set(ByVal Value As DateTime)
            If _Fecha_Cierre <> Value Then
                RaiseEvent Fecha_CierreChanging(Value)
                Me._Fecha_Cierre = Value
                RaiseEvent Fecha_CierreChanged()
            End If
        End Set
    End Property

    Public Event CierreChanging(ByVal Value As Boolean)
    Public Event CierreChanged()

    Public Property Cierre() As Boolean
        Get
            Return Me._Cierre
        End Get
        Set(ByVal Value As Boolean)
            If _Cierre <> Value Then
                RaiseEvent CierreChanging(Value)
                Me._Cierre = Value
                RaiseEvent CierreChanged()
            End If
        End Set
    End Property

    Public Event ObservacionesChanging(ByVal Value As String)
    Public Event ObservacionesChanged()

    Public Property Observaciones() As String
        Get
            Return Me._Observaciones
        End Get
        Set(ByVal Value As String)
            If _Observaciones <> Value Then
                RaiseEvent ObservacionesChanging(Value)
                Me._Observaciones = Value
                RaiseEvent ObservacionesChanged()
            End If
        End Set
    End Property

    Public Event Id_Declaracion_SeguimientoChanging(ByVal Value As Int32)
    Public Event Id_Declaracion_SeguimientoChanged()

    Public Property Id_Declaracion_Seguimiento() As Int32
        Get
            Return Me._Id_Declaracion_Seguimiento
        End Get
        Set(ByVal Value As Int32)
            If _Id_Declaracion_Seguimiento <> Value Then
                RaiseEvent Id_Declaracion_SeguimientoChanging(Value)
                Me._Id_Declaracion_Seguimiento = Value
                RaiseEvent Id_Declaracion_SeguimientoChanged()
            End If
        End Set
    End Property

    Public Event Id_Municipio_InstitutoChanging(ByVal Value As Int32)
    Public Event Id_Municipio_InstitutoChanged()

    Public Property Id_Municipio_Instituto() As Int32
        Get
            Return Me._Id_Municipio_Instituto
        End Get
        Set(ByVal Value As Int32)
            If _Id_Municipio_Instituto <> Value Then
                RaiseEvent Id_Municipio_InstitutoChanging(Value)
                Me._Id_Municipio_Instituto = Value
                RaiseEvent Id_Municipio_InstitutoChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property TipoSeguimiento As String
        Get
            If SubtablasTipoSeguimiento Is Nothing Then
                Return "Otro"
            Else
                Return SubtablasTipoSeguimiento.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property SubtablasTipoSeguimiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Tipo_Entrega)
        End Get
    End Property

    Public ReadOnly Property SubTablasCertificado_Matricula() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Certificado_Matricula)
        End Get
    End Property

    Public ReadOnly Property SubTablasEstudia_Actualmente() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Estudia_Actualmente)
        End Get
    End Property

    Public ReadOnly Property SubTablasGrado_Escolar() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_grado_escolar)
        End Get
    End Property

    Public ReadOnly Property SubTablasMotivo_NoEstudia() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Motivo_NoEstudia)
        End Get
    End Property

    Public ReadOnly Property Personas() As PersonasBrl
        Get
            Return PersonasBrl.CargarPorID(Id_Persona)
        End Get
    End Property

    Public ReadOnly Property SubTablasSeguimiento() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Seguimiento)
        End Get
    End Property

    Public ReadOnly Property Municipio_Institucion() As SubTablasBrl
        Get
            Return SubTablasBrl.CargarPorID(Id_Municipio_Instituto)
        End Get
    End Property


    Public ReadOnly Property Certificado() As String
        Get
            If SubTablasCertificado_Matricula Is Nothing Then
                Return ""
            Else
                Return SubTablasCertificado_Matricula.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Estudia_Actualmente() As String
        Get
            If SubTablasEstudia_Actualmente Is Nothing Then
                Return ""
            Else
                Return SubTablasEstudia_Actualmente.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Grado_Escolar() As String
        Get
            If SubTablasGrado_Escolar Is Nothing Then
                Return ""
            Else
                Return SubTablasGrado_Escolar.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property MotivoNoEstudia() As String
        Get
            If SubTablasMotivo_NoEstudia Is Nothing Then
                Return ""
            Else
                Return SubTablasMotivo_NoEstudia.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Seguimiento() As String
        Get
            If SubTablasSeguimiento Is Nothing Then
                Return ""
            Else
                Return SubTablasSeguimiento.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property Declaracion_Seguimiento() As Declaracion_SeguimientosBrl
        Get
            Return Declaracion_SeguimientosBrl.CargarPorID(Id_Declaracion_Seguimiento)
        End Get
    End Property


    Public Event Saving()
    Public Event Saved()

    Public Event Inserting()
    Public Event Inserted()

    Public Event Updating()
    Public Event Updated()

    Public Event Deleting()
    Public Event Deleted()


    Public Sub Guardar()
        RaiseEvent Saving()
        If (Me.ID = Nothing) Then
            RaiseEvent Inserting()
            Me.ID = Personas_EducacionDAL.Insertar(Id_Persona, Fecha, Id_Estudia_Actualmente, Id_Motivo_NoEstudia, Id_Certificado_Matricula, Id_Seguimiento, Establecimiento, Id_grado_escolar, Verificado_Entidad, Fecha_Cierre, Cierre, Observaciones, Id_Tipo_Entrega, Id_Declaracion_Seguimiento, Id_Municipio_Instituto)
            RaiseEvent Inserted()
        Else
            RaiseEvent Updating()
            Personas_EducacionDAL.Actualizar(ID, Id_Persona, Fecha, Id_Estudia_Actualmente, Id_Motivo_NoEstudia, Id_Certificado_Matricula, Id_Seguimiento, Establecimiento, Id_grado_escolar, Verificado_Entidad, Fecha_Cierre, Cierre, Observaciones, Id_Tipo_Entrega, Id_Declaracion_Seguimiento, Id_Municipio_Instituto)
            RaiseEvent Updated()
        End If

        RaiseEvent Saved()

    End Sub

    Public Sub Eliminar()
        Dim totalHijos As Long = 0
        If Me.ID <> Nothing Then

            RaiseEvent Deleting()
            If totalHijos > 0 Then Throw New Exception("No se puede eliminar el registro porque existen datos que dependen de él.")
            Personas_EducacionDAL.Eliminar(Me.ID)

            RaiseEvent Deleted()

        End If
    End Sub

    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As Personas_EducacionBrl

        Dim objPersonas_Educacion As New Personas_EducacionBrl

        With objPersonas_Educacion
            .ID = fila("Id")
            .Id_Persona = isDBNullToNothing(fila("Id_Persona"))
            .Fecha = isDBNullToNothing(fila("Fecha"))
            .Id_Estudia_Actualmente = isDBNullToNothing(fila("Id_Estudia_Actualmente"))
            .Id_Motivo_NoEstudia = isDBNullToNothing(fila("Id_Motivo_NoEstudia"))
            .Id_Certificado_Matricula = isDBNullToNothing(fila("Id_Certificado_Matricula"))
            .Id_Seguimiento = isDBNullToNothing(fila("Id_Seguimiento"))
            .Establecimiento = isDBNullToNothing(fila("Establecimiento"))
            .Id_grado_escolar = isDBNullToNothing(fila("Id_grado_escolar"))
            .Verificado_Entidad = isDBNullToNothing(fila("Verificado_Entidad"))
            .Fecha_Cierre = isDBNullToNothing(fila("Fecha_Cierre"))
            .Cierre = isDBNullToNothing(fila("Cierre"))
            .Observaciones = isDBNullToNothing(fila("Observaciones"))
            .Id_Tipo_Entrega = isDBNullToNothing(fila("Id_Tipo_Entrega"))
            .Id_Municipio_Instituto = isDBNullToNothing(fila("Id_Municipio_Instituto"))
            .Id_Declaracion_Seguimiento = isDBNullToNothing(fila("Id_Declaracion_Seguimiento"))
        End With

        Return objPersonas_Educacion

    End Function

    Public Shared Event LoadingPersonas_EducacionList(ByVal LoadType As String)
    Public Shared Event LoadedPersonas_EducacionList(ByVal target As List(Of Personas_EducacionBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of Personas_EducacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        RaiseEvent LoadingPersonas_EducacionList("CargarTodos")

        dsDatos = Personas_EducacionDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event CargandoPorId(ByVal id As Int32)
    Public Shared Event CargadoPorId(ByVal target As Personas_EducacionBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As Personas_EducacionBrl
        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Educacion As Personas_EducacionBrl = Nothing
        dsDatos = Personas_EducacionDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Educacion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPersonas_Educacion
    End Function

    Public Shared Function CargarPorId_PersonaySegunda_Entrega(ByVal ID As Int32, ByVal Id_Tipo_Entrega As Int32) As Personas_EducacionBrl
        Dim dsDatos As System.Data.DataSet
        Dim objPersonas_Educacion As Personas_EducacionBrl = Nothing
        dsDatos = Personas_EducacionDAL.CargarPorIDySegunda_Entrega(ID, Id_Tipo_Entrega)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objPersonas_Educacion = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objPersonas_Educacion
    End Function

    Public Shared Function CargarPorId_Certificado_Matricula(ByVal Id_Certificado_Matricula As Int32) As List(Of Personas_EducacionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)
        RaiseEvent LoadingPersonas_EducacionList("CargarPorId_Certificado_Matricula")
        dsDatos = Personas_EducacionDAL.CargarPorId_Certificado_Matricula(Id_Certificado_Matricula)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarPorId_Certificado_Matricula")
        Return lista

    End Function

    Public Shared Function CargarPorId_Estudia_Actualmente(ByVal Id_Estudia_Actualmente As Int32) As List(Of Personas_EducacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        RaiseEvent LoadingPersonas_EducacionList("CargarPorId_Estudia_Actualmente")
        dsDatos = Personas_EducacionDAL.CargarPorId_Estudia_Actualmente(Id_Estudia_Actualmente)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarPorId_Estudia_Actualmente")
        Return lista

    End Function

    Public Shared Function CargarPorId_grado_escolar(ByVal Id_grado_escolar As Int32) As List(Of Personas_EducacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        RaiseEvent LoadingPersonas_EducacionList("CargarPorId_grado_escolar")
        dsDatos = Personas_EducacionDAL.CargarPorId_Grado_Escolar(Id_grado_escolar)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarPorId_grado_escolar")

        Return lista

    End Function

    Public Shared Function CargarPorId_Motivo_NoEstudia(ByVal Id_Motivo_NoEstudia As Int32) As List(Of Personas_EducacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        RaiseEvent LoadingPersonas_EducacionList("CargarPorId_Motivo_NoEstudia")
        dsDatos = Personas_EducacionDAL.CargarPorId_Motivo_NoEstudia(Id_Motivo_NoEstudia)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarPorId_Motivo_NoEstudia")

        Return lista

    End Function

    Public Shared Function CargarPorId_Persona(ByVal Id_Persona As Int32) As List(Of Personas_EducacionBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        RaiseEvent LoadingPersonas_EducacionList("CargarPorId_Persona")

        dsDatos = Personas_EducacionDAL.CargarPorId_Persona(Id_Persona)

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedPersonas_EducacionList(lista, "CargarPorId_Persona")

        Return lista

    End Function

    Public Shared Function CargarPorId_Seguimiento(ByVal Id_Seguimiento As Int32) As List(Of Personas_EducacionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)
        dsDatos = Personas_EducacionDAL.CargarPorId_Seguimiento(Id_Seguimiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Tipo_Entrega(ByVal Id_Tipo_Entrega As Int32) As List(Of Personas_EducacionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)
        dsDatos = Personas_EducacionDAL.CargarPorId_Tipo_Entrega(Id_Tipo_Entrega)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next
        Return lista
    End Function

    Public Shared Function CargarPorId_Declaracion_Seguimiento(ByVal Id_Declaracion_Seguimiento As Int32) As List(Of Personas_EducacionBrl)
        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of Personas_EducacionBrl)

        dsDatos = Personas_EducacionDAL.CargarPorId_Declaracion_Seguimiento(Id_Declaracion_Seguimiento)
        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        Return lista

    End Function

End Class


