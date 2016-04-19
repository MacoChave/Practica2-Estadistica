Public Class AnalisisLexico
    'CONTROL DE ESTADOS
    Dim estado As Integer
    Dim caracter As Char
    Dim tipoCaracter As Integer
    Dim fila As Integer
    Dim columna As Integer
    'CONTROL DE TOKEN
    Dim id_aux As Integer
    Dim lexema As String
    Dim token As String
    Dim tokenEncontrado As New Token
    Dim errorEncontrado As New Errores

    Public Sub Analizar(texto As String)
        estado = 0
        fila = 1
        columna = 0
        texto += "#"
        ListaToken.listaToken.Clear()
        ListaError.listaError.Clear()
        ListaGrafica.listaGrafica.Clear()
        ListaIntervalo.listaIntervalo.Clear()

        For i As Integer = 0 To texto.Length - 1 Step 1
            caracter = texto.Chars(i)
            tipoCaracter = Get_TipoCaracter(caracter)
            Select Case estado
                Case 0 'A
                    Select Case tipoCaracter
                        Case 0 '[A-Z]
                            lexema = caracter
                            estado = 1
                            columna += 1
                        Case 2 'ESPACIO
                            tokenEncontrado = New Token
                            tokenEncontrado._id = tipoCaracter
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = "' '"
                            tokenEncontrado._token = "ESPACIO"
                            ListaToken.listaToken.Add(tokenEncontrado)

                            columna += 1
                        Case 3 '[0-9]
                            lexema = caracter
                            estado = 4
                            columna += 1
                        Case 4 '{
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "LLAVE DE APERTURA"
                            id_aux = tipoCaracter
                        Case 5 '}
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "LLAVE DE CIERRE"
                            id_aux = tipoCaracter
                        Case 6 ';
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CARACTER PUNTO Y COMA"
                            id_aux = tipoCaracter
                        Case 7 ':
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CARACTER DOS PUNTOS"
                            id_aux = tipoCaracter
                        Case 8 '=
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CARACTER IGUAL"
                            id_aux = tipoCaracter
                        Case 9 ',
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CARACTER COMA"
                            id_aux = tipoCaracter
                        Case 10 '-
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CARACTER GUIÓN"
                            id_aux = tipoCaracter
                        Case 11 '[
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CORCHETE DE APERTURA"
                            id_aux = tipoCaracter
                        Case 12 ']
                            lexema = caracter
                            estado = 2
                            columna += 1
                            token = "CORCHETE DE CIERRE"
                            id_aux = tipoCaracter
                        Case 13 'COMILLAS DOBLES
                            lexema = caracter
                            estado = 3
                            columna += 1
                        Case 14 '#
                            MessageBox.Show("¡Análisis Léxico Finalizado!", "¡EXITO!")
                        Case 15 'TAB
                            tokenEncontrado = New Token
                            tokenEncontrado._id = 15
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = "TAB"
                            tokenEncontrado._token = "TABULADOR"
                            ListaToken.listaToken.Add(tokenEncontrado)

                            columna += 4
                        Case 16 'SALTO
                            tokenEncontrado = New Token
                            tokenEncontrado._id = 16
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = "Retorno"
                            tokenEncontrado._token = "RETORNO"
                            ListaToken.listaToken.Add(tokenEncontrado)

                            fila += 1
                            columna = 0
                        Case Else 'CUALQUIER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 1 'B
                    Select Case tipoCaracter
                        Case 1 '[a-z]
                            lexema += caracter
                            estado = 5
                            columna += 1
                        Case Else 'CUALQUIER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 2 'C
                    tokenEncontrado = New Token
                    tokenEncontrado._id = id_aux
                    tokenEncontrado._columna = columna
                    tokenEncontrado._fila = fila
                    tokenEncontrado._lexema = lexema
                    tokenEncontrado._token = token
                    ListaToken.listaToken.Add(tokenEncontrado)

                    estado = 0
                    lexema = Nothing
                    token = Nothing
                    id_aux = Nothing
                    i -= 1
                Case 3 'D
                    Select Case tipoCaracter
                        Case 0 '[A-Z]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 1 '[a-z]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 2 'ESPACIO
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 3 '[0-9]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 7 ':
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case Else 'CUALQUER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 4 'E
                    Select Case tipoCaracter
                        Case 3 '[0-9]
                            lexema += caracter
                            estado = 4
                            columna += 1
                        Case 24 '.
                            lexema += caracter
                            estado = 8
                            columna += 1
                        Case Else 'CUALQUIER OTRO CARACTER
                            tokenEncontrado = New Token
                            tokenEncontrado._id = 3
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = lexema
                            tokenEncontrado._token = "ENTERO"
                            ListaToken.listaToken.Add(tokenEncontrado)

                            lexema = Nothing
                            estado = 0
                            i -= 1
                    End Select
                Case 5 'F
                    Select Case tipoCaracter
                        Case 1 '[a-z]
                            lexema += caracter
                            estado = 5
                            columna += 1
                        Case 2 'ESPACIO
                            If (lexema.Equals("Intervalo")) Then
                                token = "RESERVADA INTERVALO"
                                lexema += caracter
                                id_aux = 21
                                estado = 7
                            ElseIf (lexema.Equals("Grafica")) Then
                                token = "RESERVADA GRAFICA"
                                estado = 2
                                id_aux = 17
                                i -= 1
                            ElseIf (lexema.Equals("Nombre")) Then
                                token = "RESERVADA NOMBRE"
                                estado = 2
                                id_aux = 18
                                i -= 1
                            ElseIf (lexema.Equals("Tipo")) Then
                                token = "RESERVADA TIPO"
                                estado = 2
                                id_aux = 19
                                i -= 1
                            ElseIf (lexema.Equals("Datos")) Then
                                token = "RESERVADA DATOS"
                                estado = 2
                                id_aux = 20
                                i -= 1
                            Else
                                errorEncontrado = New Errores
                                errorEncontrado._lexema = lexema
                                errorEncontrado._columna = columna
                                errorEncontrado._fila = fila
                                errorEncontrado._descripcion = "Error léxico, se esperaba una reservada"
                                ListaError.listaError.Add(errorEncontrado)

                                estado = 0
                                i -= 1
                            End If
                            columna += 1
                        Case Else
                            If (lexema.Equals("Grafica")) Then
                                token = "RESERVADA GRAFICA"
                                id_aux = 17
                                estado = 2
                            ElseIf (lexema.Equals("Nombre")) Then
                                token = "RESERVADA NOMBRE"
                                id_aux = 18
                                estado = 2
                            ElseIf (lexema.Equals("Tipo")) Then
                                token = "RESERVADA TIPO"
                                id_aux = 19
                                estado = 2
                            ElseIf (lexema.Equals("Datos")) Then
                                token = "RESERVADA DATOS"
                                id_aux = 20
                                estado = 2
                            Else
                                errorEncontrado = New Errores
                                errorEncontrado._lexema = lexema
                                errorEncontrado._columna = columna
                                errorEncontrado._fila = fila
                                errorEncontrado._descripcion = "Error léxico, se esperaba una reservada"
                                ListaError.listaError.Add(errorEncontrado)

                            End If
                            estado = 2
                            i -= 1
                    End Select
                Case 6 'G
                    Select Case tipoCaracter
                        Case 0 '[A-Z]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 1 '[a-z]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 2 'ESPACIO
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 3 '[0-9]
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 7 ':
                            lexema += caracter
                            estado = 6
                            columna += 1
                        Case 13 'COMILLAS
                            lexema += caracter
                            token = "CADENA DE TEXTO"
                            id_aux = 22
                            estado = 2
                            columna += 1
                        Case Else 'CUALQUER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 7 'H
                    Select Case tipoCaracter
                        Case 3 '[0-9]
                            lexema += caracter
                            estado = 2
                            columna += 1
                        Case Else 'CUALQUER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 8 'I
                    Select Case tipoCaracter
                        Case 3 '[0-9]
                            lexema += caracter
                            estado = 9
                            columna += 1
                        Case Else 'CUALQUER OTRO CARACTER
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error Léxico desconocido"
                            ListaError.listaError.Add(errorEncontrado)

                            columna += 1
                    End Select
                Case 9 'J
                    Select Case tipoCaracter
                        Case 3 '[0-9]
                            lexema += caracter
                            columna += 1
                        Case Else 'CUALQUIER OTRO CARACTER
                            tokenEncontrado = New Token
                            tokenEncontrado._id = 1
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = lexema
                            tokenEncontrado._token = "DECIMAL"
                            ListaToken.listaToken.Add(tokenEncontrado)

                            lexema = Nothing
                            estado = 0
                            i -= 1
                    End Select
            End Select
        Next
    End Sub

    Private Function Get_TipoCaracter(caracter) As Integer
        Dim indice As Integer
        Select Case caracter
            Case "A" To "Z"
                indice = 0
            Case "a" To "z"
                indice = 1
            Case Chr(32) 'ESPACIO
                indice = 2
            Case "0" To "9"
                indice = 3
            Case "{"
                indice = 4
            Case "}"
                indice = 5
            Case ";"
                indice = 6
            Case ":"
                indice = 7
            Case "="
                indice = 8
            Case ","
                indice = 9
            Case "-"
                indice = 10
            Case "["
                indice = 11
            Case "]"
                indice = 12
            Case Chr(34) 'COMILLAS DOBLES
                indice = 13
            Case "#"
                indice = 14
            Case Chr(9) 'TAB
                indice = 15
            Case Chr(10) 'SALTO
                indice = 16
            Case "."
                indice = 24
        End Select

        Return indice
    End Function
End Class
