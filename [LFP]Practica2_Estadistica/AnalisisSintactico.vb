Public Class AnalisisSintactico
    'CONTROL DE PRODUCCIONES
    Dim produccion As Integer = 0
    Dim id_token As Integer
    'NOTIFICAR ERRORES
    Dim errores As Boolean = False
    Dim errorEncontrado As New Errores
    'DATOS DE GRAFICA
    Dim auxReservada As String
    Dim auxValor As Integer = 0
    Dim MarcaClase As Single
    Dim nombre As String
    Dim tipo As String
    Dim limInf As Single
    Dim limSup As Single
    Dim valor As Integer
    Dim id_grafica As Integer = 0
    Dim grafica As New Grafica
    Dim intervalo As New Intervalo

    Public Sub Analizar()
        For t As Integer = 0 To ListaToken.listaToken.Count - 1 Step 1
            id_token = ListaToken.listaToken.Item(t)._id
            Select Case produccion
                Case 0 '<programa>
                    Select Case id_token
                        Case 17 'RESERVADA GRAFICA
                            produccion = 1
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba Reservada Grafica"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 1 'GRAFICA
                    Select Case id_token
                        Case 4 '{
                            produccion = 2
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba {"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 2 '{
                    Select Case id_token
                        Case 18, 19 'RESERVADA NOMBRE, RESERVADA TIPO
                            auxReservada = ListaToken.listaToken.Item(t)._token
                            produccion = 5
                        Case 20 'RESERVADA DATOS
                            produccion = 10
                        Case 5 '}
                            grafica = New Grafica
                            grafica._id_grafica = id_grafica
                            grafica._nombre = nombre
                            grafica._tipo = tipo
                            ListaGrafica.listaGrafica.Add(grafica)

                            nombre = Nothing
                            tipo = Nothing
                            produccion = 4
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba }"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 4 '}
                    Select Case id_token
                        Case 17 'RESERVADA GRAFICA
                            produccion = 1
                            id_grafica += 1
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba Reservada Grafica"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 5 'NOMBRE/TIPO
                    Select Case id_token
                        Case 7 ':
                            produccion = 6
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba :"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 6 ':
                    Select Case id_token
                        Case 22 'TEXTO
                            If (auxReservada.Equals("RESERVADA NOMBRE")) Then
                                nombre = ListaToken.listaToken.Item(t)._lexema
                            ElseIf (auxReservada.Equals("RESERVADA TIPO")) Then
                                tipo = ListaToken.listaToken.Item(t)._lexema
                            End If
                            auxReservada = Nothing
                            produccion = 7
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba token texto"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 7 'TEXTO
                    Select Case id_token
                        Case 6 ';
                            produccion = 2
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ;"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 10 'DATOS
                    Select Case id_token
                        Case 7 ':
                            produccion = 11
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba :"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 11 ':
                    Select Case id_token
                        Case 4 '{
                            produccion = 12
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba {"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 12 '{
                    Select Case id_token
                        Case 21 'RESERVADA INTERVALO
                            produccion = 15
                        Case 5 '}
                            auxValor = 0
                            produccion = 2
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba }"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 15 'INTERVALO
                    Select Case id_token
                        Case 8 '=
                            produccion = 16
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ="
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 16 '=
                    Select Case id_token
                        Case 4 '{
                            produccion = 17
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba {"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 17 '{
                    Select Case id_token
                        Case 11 '[
                            produccion = 18
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ["
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 18 '[
                    Select Case id_token
                        Case 3 'DIGITO
                            limInf = Single.Parse(ListaToken.listaToken.Item(t)._lexema).ToString
                            produccion = 19
                        Case 1 'DECIMAL
                            limInf = Single.Parse(ListaToken.listaToken.Item(t)._lexema).ToString
                            produccion = 19
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba un entero"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 19 'ENTERO
                    Select Case id_token
                        Case 10 '-
                            produccion = 20
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba -"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 20 '-
                    Select Case id_token
                        Case 3 'DIGITO
                            limSup = Single.Parse(ListaToken.listaToken.Item(t)._lexema).ToString
                            produccion = 21
                        Case 1 'DECIMAL
                            limSup = Single.Parse(ListaToken.listaToken.Item(t)._lexema).ToString
                            produccion = 21
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba un entero"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 21 'ENTERO
                    Select Case id_token
                        Case 12 ']
                            produccion = 22
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ]"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 22 ']
                    Select Case id_token
                        Case 9 ',
                            produccion = 23
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ,"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 23 ',
                    Select Case id_token
                        Case 3 'DIGITO
                            Dim auxMC As Single = (limInf + limSup) / 2
                            valor = Integer.Parse(ListaToken.listaToken.Item(t)._lexema).ToString
                            auxValor = auxValor + valor
                            intervalo = New Intervalo
                            intervalo._id_grafica = id_grafica
                            intervalo._lim_Inferior = limInf
                            intervalo._lim_Superior = limSup
                            intervalo._valor = valor
                            intervalo._frecAcumulada = auxValor
                            intervalo._marcaClase = auxMC
                            intervalo._frecMc = valor * auxMC
                            ListaIntervalo.listaIntervalo.Add(intervalo)

                            limInf = Nothing
                            limSup = Nothing
                            valor = Nothing
                            produccion = 24
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba un entero"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 24 'ENTERO
                    Select Case id_token
                        Case 5 '}
                            produccion = 25
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba }"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
                Case 25 '}
                    Select Case id_token
                        Case 6 ';
                            produccion = 12
                        Case 2, 15, 16 'ESPACIO, TAB, SALTO
                            'IGNORAR
                        Case Else 'ERROR SINTACTICO
                            errorEncontrado = New Errores
                            errorEncontrado._lexema = ListaToken.listaToken.Item(t)._lexema
                            errorEncontrado._columna = ListaToken.listaToken.Item(t)._columna
                            errorEncontrado._fila = ListaToken.listaToken.Item(t)._fila
                            errorEncontrado._descripcion = "Error sintactico. Se esperaba ;"
                            ListaError.listaError.Add(errorEncontrado)

                            errores = True
                    End Select
            End Select
        Next

        If (errores) Then
            MessageBox.Show("Se encontraron errores sintácticos", "¡ERROR!")
        Else
            MessageBox.Show("Análisis Sintáctico finalizado satisfactoriamente", "¡EXITO!")
        End If
    End Sub
End Class