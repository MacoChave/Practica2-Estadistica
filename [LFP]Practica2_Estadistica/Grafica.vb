Public Class Grafica
    Private id_grafica As Integer
    Private nombre As String
    Private tipo As String
    Private k As Integer
    Private N As Integer
    Private Fr As Single
    Private Ma As Single
    Private frecMax As Integer
    Private frecMin As Integer
    Private amplitud As Single
    Private Mo As Single
    Private Md As Single
    Private intervaloMd As String
    Private intervaloMo As String

    Sub New()

    End Sub

    Sub New(id_grafica As Integer, nombre As String, tipo As String, k As Integer, N As Integer, Fr As Single, Md As Single, frecMax As Integer, frecMin As Integer, amplitud As Single, Mo As Single, Ma As Single, intervaloMd As String, intervaloMo As String)
        Me.id_grafica = id_grafica
        Me.nombre = nombre
        Me.tipo = tipo
        Me.k = tipo
        Me.N = N
        Me.Fr = Fr
        Me.frecMax = frecMax
        Me.frecMin = frecMin
        Me.amplitud = amplitud
        Me.Mo = Mo
        Me.Ma = Ma
        Me.Md = Md
        Me.intervaloMd = intervaloMd
        Me.intervaloMo = intervaloMo
    End Sub

    Public Property _id_grafica As Integer
        Get
            Return id_grafica
        End Get
        Set(value As Integer)
            id_grafica = value
        End Set
    End Property

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property _tipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Public Property _k As Integer
        Get
            Return k
        End Get
        Set(value As Integer)
            k = value
        End Set
    End Property

    Public Property _N As Integer
        Get
            Return N
        End Get
        Set(value As Integer)
            N = value
        End Set
    End Property

    Public Property _Fr As Single
        Get
            Return Fr
        End Get
        Set(value As Single)
            Fr = value
        End Set
    End Property

    Public Property _Md As Single
        Get
            Return Md
        End Get
        Set(value As Single)
            Md = value
        End Set
    End Property

    Public Property _frecMax As Integer
        Get
            Return frecMax
        End Get
        Set(value As Integer)
            frecMax = value
        End Set
    End Property

    Public Property _frecMin As Integer
        Get
            Return frecMin
        End Get
        Set(value As Integer)
            frecMin = value
        End Set
    End Property

    Public Property _amplitud As Single
        Get
            Return amplitud
        End Get
        Set(value As Single)
            amplitud = value
        End Set
    End Property

    Public Property _Mo As Single
        Get
            Return Mo
        End Get
        Set(value As Single)
            Mo = value
        End Set
    End Property

    Public Property _Ma As Single
        Get
            Return Ma
        End Get
        Set(value As Single)
            Ma = value
        End Set
    End Property

    Public Property _intervaloMd As String
        Get
            Return intervaloMd
        End Get
        Set(value As String)
            intervaloMd = value
        End Set
    End Property

    Public Property _intervaloMo As String
        Get
            Return intervaloMo
        End Get
        Set(value As String)
            intervaloMo = value
        End Set
    End Property
End Class