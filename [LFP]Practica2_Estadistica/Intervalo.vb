Public Class Intervalo
    Private id_grafica As Integer
    Private lim_Inferior As Single
    Private lim_Superior As Single
    Private valor As Integer
    Private marcaClase As Single
    Private frecAcumulada As Integer
    Private frecRel As Single
    Private frecRelA As Single
    Private frecMc As Single

    Sub New()

    End Sub

    Sub New(id_grafica As Integer, lim_Inferior As Single, lim_Superior As Single, valor As Integer, frecAcumulada As Integer, frecRel As Single, frecRelA As Single, marcaClase As Single, frecMc As Single)
        Me.id_grafica = id_grafica
        Me.lim_Inferior = lim_Inferior
        Me.lim_Superior = lim_Superior
        Me.valor = valor
        Me.frecAcumulada = frecAcumulada
        Me.frecRel = frecRel
        Me.frecRelA = frecRelA
        Me.marcaClase = marcaClase
        Me.frecMc = frecMc
    End Sub

    Public Property _id_grafica As Integer
        Get
            Return id_grafica
        End Get
        Set(value As Integer)
            id_grafica = value
        End Set
    End Property

    Public Property _lim_Inferior As Single
        Get
            Return lim_Inferior
        End Get
        Set(value As Single)
            lim_Inferior = value
        End Set
    End Property

    Public Property _lim_Superior As Single
        Get
            Return lim_Superior
        End Get
        Set(value As Single)
            lim_Superior = value
        End Set
    End Property

    Public Property _valor As Integer
        Get
            Return valor
        End Get
        Set(value As Integer)
            valor = value
        End Set
    End Property

    Public Property _frecAcumulada As Integer
        Get
            Return frecAcumulada
        End Get
        Set(value As Integer)
            frecAcumulada = value
        End Set
    End Property

    Public Property _frecRel As Single
        Get
            Return frecRel
        End Get
        Set(value As Single)
            frecRel = value
        End Set
    End Property

    Public Property _frecRelA As Single
        Get
            Return frecRelA
        End Get
        Set(value As Single)
            frecRelA = value
        End Set
    End Property

    Public Property _marcaClase As Single
        Get
            Return marcaClase
        End Get
        Set(value As Single)
            marcaClase = value
        End Set
    End Property

    Public Property _frecMc As Integer
        Get
            Return frecMc
        End Get
        Set(value As Integer)
            frecMc = value
        End Set
    End Property
End Class
