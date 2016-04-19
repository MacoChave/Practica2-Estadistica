Imports System.IO
Imports System.Text

Public Class crearArchivo
    'Dim k As Integer = 0
    'Dim fra As Integer = 0
    'Dim N As Integer = 0
    'Dim _a As Integer
    'Dim _X As Integer
    'Dim Mo As Integer
    'Dim Md As Integer
    Public Sub tokenHtml()
        Dim html As String
        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "table.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Tabla de Token</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<ul><li><a href=" & Chr(34) & "grafica.html" & Chr(34) & ">Resultados</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Lista Token</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "error.html" & Chr(34) & ">Lista Error</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "simbolo.html" & Chr(34) & ">Tabla Simbolos</a></li></ul>" & vbCrLf
        html += "<h1>Token Reconocidos</h1>" & vbCrLf
        html += "<table>" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<th>No</th>" & vbCrLf
        html += "<th>Lexema</th>" & vbCrLf
        html += "<th>Token</th>" & vbCrLf
        html += "<th>Posición</th>" & vbCrLf
        html += "</tr>" & vbCrLf

        For t As Integer = 0 To ListaToken.listaToken.Count - 1 Step 1
            html += "<tr><td>" & t + 1 & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._lexema & "</td>" & vbCrLf
            html += "<td>" & ListaToken.listaToken.Item(t)._token & "</td>" & vbCrLf
            html += "<td> Fila " & ListaToken.listaToken.Item(t)._fila & ", columna " & ListaToken.listaToken.Item(t)._columna & "</td>" & vbCrLf
            html += "</tr>" & vbCrLf
        Next

        html += "</table>" & vbCrLf
        html += "<footer><p><b>Lenguajes Formales y de Programación</b></p>" & vbCrLf
        html += "<p>Marco Antonio Chávez Fuentes</p>" & vbCrLf
        html += "<p>2010-20831</p></footer>" & vbCrLf
        html += "</body>" & vbCrLf
        html += "</html>"
        'Dim path As String = "C:\Users\Public\Documents\token.html"
        Dim path As String = "C:\Users\u\Desktop\token.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Public Sub errorHtml()
        Dim html As String
        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "table.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Tabla de Errores</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<ul><li><a href=" & Chr(34) & "grafica.html" & Chr(34) & ">Resultados</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "token.html" & Chr(34) & ">Lista Token</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Lista Error</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "simbolo.html" & Chr(34) & ">Tabla Simbolos</a></li></ul>" & vbCrLf
        html += "<h1>Token Reconocidos</h1>" & vbCrLf
        html += "<table>" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<th>No</th>" & vbCrLf
        html += "<th>Lexema</th>" & vbCrLf
        html += "<th>Posición</th>" & vbCrLf
        html += "<th>Error</th>" & vbCrLf
        html += "</tr>" & vbCrLf

        For t As Integer = 0 To ListaError.listaError.Count - 1 Step 1
            html += "<tr><td>" & t + 1 & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(t)._lexema & "</td>" & vbCrLf
            html += "<td> Fila " & ListaError.listaError.Item(t)._fila & ", columna " & ListaError.listaError.Item(t)._columna & "</td>" & vbCrLf
            html += "<td>" & ListaError.listaError.Item(t)._descripcion & "</td>" & vbCrLf
            html += "</tr>" & vbCrLf
        Next

        html += "</table>" & vbCrLf
        html += "<footer><p><b>Lenguajes Formales y de Programación</b></p>" & vbCrLf
        html += "<p>Marco Antonio Chávez Fuentes</p>" & vbCrLf
        html += "<p>2010-20831</p></footer>" & vbCrLf
        html += "</body>" & vbCrLf
        html += "</html>"
        'Dim path As String = "C:\Users\Public\Documents\error.html"
        Dim path As String = "C:\Users\u\Desktop\error.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Public Sub graficaHTML()
        'CONTADOR HTML
        Dim contador_id As Integer = 0
        Dim auxConta_for As Integer = 0
        Dim contador_for As Integer
        'Dim cambio As Boolean = False
        'Dim scritpt As Boolean = False
        Dim html As String
        Dim script As String = "<!--INICIO DEL SCRIPT-->" & vbCrLf
        'COMPLETAR TABLA
        obtenerK()
        comTabla()
        mediana()
        '" & Chr(34) & "

        html = "<!DOCTYPE html>" & vbCrLf
        html += "<html lang=" & Chr(34) & "es" & Chr(34) & ">" & vbCrLf
        html += "<head>" & vbCrLf
        html += "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf
        html += "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " href=" & Chr(34) & "table.css" & Chr(34) & ">" & vbCrLf
        html += "<title>Resultados Estadisticos</title>" & vbCrLf
        html += "</head>" & vbCrLf
        html += "<body>" & vbCrLf
        html += "<header>" & vbCrLf
        html += "<ul>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "#" & Chr(34) & ">Resultados</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "token.html" & Chr(34) & ">Lista Token</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "error.html" & Chr(34) & ">Lista Error</a></li>" & vbCrLf
        html += "<li><a href=" & Chr(34) & "simbolo" & Chr(34) & ">Tabla Simbolos</a></li>" & vbCrLf
        html += "</ul>" & vbCrLf
        html += "</header>" & vbCrLf
        html += "<main>" & vbCrLf
        html += "<h1>Resultados Estadísticos</h1>" & vbCrLf
        '<!--NOMBRE EN LISTA GRAFICA SEGÚN ID_GRAFICA-->
        html += "<h2>" & ListaGrafica.listaGrafica.Item(contador_id)._nombre & "</h2>" & vbCrLf
        html += "<table>" & vbCrLf
        html += "<tr>" & vbCrLf
        html += "<td>No</td>" & vbCrLf
        html += "<td colspan = " & Chr(34) & "2" & Chr(34) & ">Intervalo</td>" & vbCrLf
        '<!--frecuencia absoluta-->
        html += "<td>f</td>" & vbCrLf
        '<!--frecuencia acumulada-->
        html += "<td>fa</td>" & vbCrLf
        '<!--frecuencia relativa-->
        html += "<td>fr</td>" & vbCrLf
        '<!--frecuencia relativa acumulada-->
        html += "<td>fra</td>" & vbCrLf
        '<!--marca de clase-->
        html += "<td>x</td>" & vbCrLf
        '<!--frecuencia por marca de clase-->
        html += "<td>f*x</td>" & vbCrLf
        html += "</tr>" & vbCrLf

        '<!--RECORRER LISTA INTERVALO SOLO SI ID_GRAFICA COINCIDE-->
        For i As Integer = 0 To ListaIntervalo.listaIntervalo.Count - 1 Step 1
            If (ListaIntervalo.listaIntervalo.Item(i)._id_grafica = contador_id) Then
                html += obtenerFila(i, auxConta_for)
            Else

                contador_for = i - 1

                html += "</table>" & vbCrLf
                '<!--OBTENER DATOS DE LAS VARIABLES-->
                html += "<div class=" & Chr(34) & "resultado" & Chr(34) & ">" & vbCrLf
                html += "<label>Cantidad de intervalo (k): " & ListaGrafica.listaGrafica.Item(contador_id)._k & "</label>" & vbCrLf
                html += "<label>Total de observaciones (N): " & ListaGrafica.listaGrafica.Item(contador_id)._N & "</label>" & vbCrLf
                html += "<label>Amplitud (a): " & ListaGrafica.listaGrafica.Item(contador_id)._amplitud & "</label>" & vbCrLf
                html += "<label>Media Aritmética (X): " & ListaGrafica.listaGrafica.Item(contador_id)._Ma & "</label>" & vbCrLf
                html += "<label>Moda (Mo): " & ListaGrafica.listaGrafica.Item(contador_id)._Mo & "</label>" & vbCrLf
                html += "<label>Mediana (Md): " & ListaGrafica.listaGrafica.Item(contador_id)._Md & "</label>" & vbCrLf
                html += "<label>Intervalo modal: " & ListaGrafica.listaGrafica.Item(contador_id)._intervaloMo & "</label>" & vbCrLf
                html += "<label>Intervalo Mediana: " & ListaGrafica.listaGrafica.Item(contador_id)._intervaloMd & "</label>" & vbCrLf
                html += "</div>" & vbCrLf

                If (ListaGrafica.listaGrafica.Item(contador_id)._tipo.Equals(Chr(34) & "Barras" & Chr(34))) Then

                    html += "<canvas id=" & Chr(34) & "barra" & contador_id & Chr(34) & "></canvas>" & vbCrLf

                    script += obtenerScript_barras(contador_id, auxConta_for, contador_for)
                    
                Else
                    html += "<canvas id=" & Chr(34) & "pie" & contador_id & Chr(34) & "></canvas>" & vbCrLf

                    script += obtenerScript_pie(contador_id, auxConta_for, contador_for)
                    
                End If

                '<!--SIGUIENTE GRAFICA-->
                html += "<h2>" & ListaGrafica.listaGrafica.Item(contador_id)._nombre & "</h2>" & vbCrLf
                html += "<table>" & vbCrLf
                html += "<tr>" & vbCrLf
                html += "<td>No</td>" & vbCrLf
                html += "<td colspan = " & Chr(34) & "2" & Chr(34) & ">Intervalo</td>" & vbCrLf
                '<!--frecuencia absoluta-->
                html += "<td>f</td>" & vbCrLf
                '<!--frecuencia acumulada-->
                html += "<td>fa</td>" & vbCrLf
                '<!--frecuencia relativa-->
                html += "<td>fr</td>" & vbCrLf
                '<!--frecuencia relativa acumulada-->
                html += "<td>fra</td>" & vbCrLf
                '<!--marca de clase-->
                html += "<td>x</td>" & vbCrLf
                '<!--frecuencia por marca de clase-->
                html += "<td>f*x</td>" & vbCrLf
                html += "</tr>" & vbCrLf

                auxConta_for = contador_for + 1
                contador_id += 1
                i -= 1
            End If
            contador_for = i
        Next
        ''<!--RECORRER LISTA INTERVALO SOLO SI ID_GRAFICA COINCIDE-->
        'For i As Integer = auxConta_for To contador_for Step 1
        '    If (ListaGrafica.listaGrafica.Item(contador_for)._id_grafica = contador_id) Then
        '        html += obtenerFila(auxConta_for, contador_for)
        '    End If
        'Next

        html += "</table>" & vbCrLf
        '<!--OBTENER DATOS DE LAS VARIABLES-->
        html += "<div class=" & Chr(34) & "resultado" & Chr(34) & ">" & vbCrLf
        html += "<label>Cantidad de intervalo (k): " & ListaGrafica.listaGrafica.Item(contador_id)._k & "</label>" & vbCrLf
        html += "<label>Total de observaciones (N): " & ListaGrafica.listaGrafica.Item(contador_id)._N & "</label>" & vbCrLf
        html += "<label>Amplitud (a): " & ListaGrafica.listaGrafica.Item(contador_id)._amplitud & "</label>" & vbCrLf
        html += "<label>Media Aritmética (X): " & ListaGrafica.listaGrafica.Item(contador_id)._Ma & "</label>" & vbCrLf
        html += "<label>Moda (Mo): " & ListaGrafica.listaGrafica.Item(contador_id)._Mo & "</label>" & vbCrLf
        html += "<label>Mediana (Md): " & ListaGrafica.listaGrafica.Item(contador_id)._Md & "</label>" & vbCrLf
        html += "<label>Intervalo modal: " & ListaGrafica.listaGrafica.Item(contador_id)._intervaloMo & "</label>" & vbCrLf
        html += "<label>Intervalo Mediana: " & ListaGrafica.listaGrafica.Item(contador_id)._intervaloMd & "</label>" & vbCrLf
        html += "</div>" & vbCrLf

        If (ListaGrafica.listaGrafica.Item(contador_id)._tipo.Equals(Chr(34) & "Barras" & Chr(34))) Then

            html += "<canvas id=" & Chr(34) & "barra" & contador_id & Chr(34) & "></canvas>" & vbCrLf

            script += obtenerScript_barras(contador_id, auxConta_for, contador_for)

        Else
            html += "<canvas id=" & Chr(34) & "pie" & contador_id & Chr(34) & "></canvas>" & vbCrLf

            script += obtenerScript_pie(contador_id, auxConta_for, contador_for)

        End If

        html += "</main>" & vbCrLf
        html += "<footer>" & vbCrLf
        html += "<p>Lenguajes Formales y de Programación</p>" & vbCrLf
        html += "<p>Marco Antonio Fidencio Chávez Fuentes</p>" & vbCrLf
        html += "<p>2010-20831</p>" & vbCrLf
        html += "</footer>" & vbCrLf
        html += "<script src=" & Chr(34) & "Chart/Chart.min.js" & Chr(34) & "></script>" & vbCrLf
        html += "<script>" & vbCrLf & "window.onload = function(){" & vbCrLf
        html += script & "}" & vbCrLf & "</script>" & vbCrLf
        html += "</body>" & vbCrLf & "</html>" & vbCrLf
        'Dim path As String = "C:\Users\Public\Documents\grafica.html"
        Dim path As String = "C:\Users\u\Desktop\grafica.html"

        'CREAR O SOBREESCRIBIR EL ARCHIVO
        Dim fs As FileStream = File.Create(path)

        'AGREGAR EL TEXTO A EL ARCHIVO
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(html)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Private Function obtenerFila(i As Integer, auxConta_for As Integer) As String
        Dim t As String

        t = "<tr>" & vbCrLf
        t += "<td>" & (i - auxConta_for) + 1 & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._lim_Superior & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._valor & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._frecAcumulada & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._frecRel & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._frecRelA & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._marcaClase & "</td>" & vbCrLf
        t += "<td>" & ListaIntervalo.listaIntervalo.Item(i)._frecMc & "</td>"
        t += "</tr>" & vbCrLf

        Return t
    End Function

    Private Function obtener_labels(auxConta_for As Integer, contador_for As Integer) As String
        Dim intervalo As String = ""
        For i As Integer = auxConta_for To contador_for Step 1
            intervalo += i + 1 & ","
            'intervalo += ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior & "-" & ListaIntervalo.listaIntervalo.Item(i)._lim_Superior & ","
        Next

        Return intervalo
    End Function

    Private Function obtener_data(auxConta_for As Integer, contador_for As Integer) As String
        Dim frecuencia As String = ""
        For i As Integer = auxConta_for To contador_for Step 1
            frecuencia += ListaIntervalo.listaIntervalo.Item(i)._valor & ","
        Next

        Return frecuencia
    End Function

    Private Function obtener_dataPie(auxConta_for As Integer, contador_for As Integer) As String
        Dim dataPie As String = ""
        For i As Integer = auxConta_for To contador_for Step 1
            dataPie += "{value: " & ListaIntervalo.listaIntervalo.Item(i)._valor & "," & vbCrLf
            dataPie += "color:  '#F7464A'," & vbCrLf
            dataPie += "highlight:  '#FF5A5E'," & vbCrLf
            dataPie += "label: '" & ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior & "-" & ListaIntervalo.listaIntervalo.Item(i)._lim_Superior & "'}," & vbCrLf
        Next

        Return dataPie
    End Function

    Private Function obtenerScript_barras(contador_id As Integer, auxConta_for As Integer, contador_for As Integer) As String
        Dim r As String
        'SCRIPT PARA BARRAS
        r = "var ctxBarra = document.getElementById('barra" & contador_id & "').getContext('2d');" & vbCrLf
        r += "var dataBar = {" & vbCrLf
        r += "labels: ["

        '//CICLO PARA INGRESAR LOS INTERVALOS
        r += obtener_labels(auxConta_for, contador_for)

        r += "]," & vbCrLf
        r += "datasets: [" & vbCrLf
        r += "{" & vbCrLf
        r += "label:  'Grafico de barras'," & vbCrLf
        r += "fillColor: " & Chr(34) & "rgba(151,187,205,0.3)" & Chr(34) & "," & vbCrLf
        r += "strokeColor: " & Chr(34) & "rgba(151,187,205,0.8)" & Chr(34) & "," & vbCrLf
        r += "highlightFill: " & Chr(34) & "rgba(151,187,205,0.75)" & Chr(34) & "," & vbCrLf
        r += "highlightStroke: " & Chr(34) & "rgba(151,187,205,1)" & Chr(34) & "," & vbCrLf
        r += "data : ["

        '//CICLO PARA INGRESAR LAS FRECUENCIAS
        r += obtener_data(auxConta_for, contador_for)

        r += "]" & vbCrLf
        r += "}"
        r += "]"
        r += "}" & vbCrLf
        r += "var myBar = new Chart(ctxBarra).Bar(dataBar, {responsive : true});" & vbCrLf

        Return r
    End Function

    Private Function obtenerScript_pie(contador_id As Integer, auxConta_for As Integer, contador_for As Integer) As String
        Dim r As String
        'SCRIPT PARA PIE
        r = "var ctxPie = document.getElementById('pie" & contador_id & "').getContext('2d');" & vbCrLf
        r += "var dataPie = [" & vbCrLf

        'CICLO PARA LAS FRECUENCIAS Y LOS INTERVALOS
        r += obtener_dataPie(auxConta_for, contador_for)

        r += "];" & vbCrLf
        r += "var myPie = new Chart(ctxPie).Pie(dataPie, {responsive: true});" & vbCrLf
        r += "}" & vbCrLf
        r += "</script>" & vbCrLf

        Return r
    End Function

    Public Sub obtenerK()
        Dim id_grafica As Integer
        Dim k As Integer

        Dim N As Integer
        Dim auxN As Integer

        Dim frecMax As Integer = 0
        Dim auxFrecMax As Integer

        Dim frecMin As Integer = 1000
        Dim auxFrecMin As Integer

        Dim inicio As Integer
        Dim valMin As Single
        Dim final As Integer
        Dim valMax As Single
        Dim amp As Single

        For i As Integer = 0 To ListaIntervalo.listaIntervalo.Count - 1 Step 1
            If (ListaIntervalo.listaIntervalo.Item(i)._id_grafica = id_grafica) Then
                k += 1

                auxN = ListaIntervalo.listaIntervalo.Item(i)._valor
                N = N + auxN

                auxFrecMax = ListaIntervalo.listaIntervalo.Item(i)._valor
                If (auxFrecMax > frecMax) Then
                    frecMax = auxFrecMax
                End If

                auxFrecMin = ListaIntervalo.listaIntervalo.Item(i)._valor
                If (auxFrecMin < frecMin) Then
                    frecMin = auxFrecMin
                End If

                final = i
            Else

                valMin = ListaIntervalo.listaIntervalo.Item(inicio)._lim_Inferior
                valMax = ListaIntervalo.listaIntervalo.Item(final)._lim_Superior
                amp = (valMax - valMin) / k

                ListaGrafica.listaGrafica.Item(id_grafica)._k = k
                ListaGrafica.listaGrafica.Item(id_grafica)._N = N
                ListaGrafica.listaGrafica.Item(id_grafica)._frecMax = frecMax
                ListaGrafica.listaGrafica.Item(id_grafica)._frecMin = frecMin
                ListaGrafica.listaGrafica.Item(id_grafica)._amplitud = amp

                id_grafica += 1
                k = 0
                N = 0
                frecMax = Nothing
                frecMin = 5000
                inicio = i
                i -= 1
            End If
        Next

        valMin = ListaIntervalo.listaIntervalo.Item(inicio)._lim_Inferior
        valMax = ListaIntervalo.listaIntervalo.Item(final)._lim_Superior
        amp = (valMax - valMin) / k

        ListaGrafica.listaGrafica.Item(id_grafica)._k = k
        ListaGrafica.listaGrafica.Item(id_grafica)._N = N
        ListaGrafica.listaGrafica.Item(id_grafica)._frecMax = frecMax
        ListaGrafica.listaGrafica.Item(id_grafica)._frecMin = frecMin
        ListaGrafica.listaGrafica.Item(id_grafica)._amplitud = amp

    End Sub
    Private Sub comTabla()
        Dim id_grafica As Integer

        Dim N As Integer
        Dim f As Integer
        Dim Fr As Single
        Dim auxFr As Single

        Dim x As Single
        Dim Ma As Single
        Dim auxMa As Single

        Dim fMax As Integer
        Dim amp As Single
        Dim limInf_modal As Single
        Dim fant_Mod As Integer
        Dim fsig_Mod As Integer
        Dim Mo As Single

        For i As Integer = 0 To ListaIntervalo.listaIntervalo.Count - 1 Step 1
            If (ListaIntervalo.listaIntervalo.Item(i)._id_grafica = id_grafica) Then

                N = ListaGrafica.listaGrafica.Item(id_grafica)._N

                'FRECUENCIA RELATIVA - f / N
                f = ListaIntervalo.listaIntervalo.Item(i)._valor
                auxFr = f / N
                ListaIntervalo.listaIntervalo.Item(i)._frecRel = auxFr
                Fr = Fr + auxFr
                ListaIntervalo.listaIntervalo.Item(i)._frecRelA = Fr

                'MEDIA ARITMETICA - SUMATORIA(f*x / N)
                x = ListaIntervalo.listaIntervalo.Item(i)._marcaClase
                auxMa = (f * x) / N
                Ma = Ma + auxMa

                If (fMax = 0) Then
                    fMax = ListaGrafica.listaGrafica.Item(id_grafica)._frecMax
                    If (ListaIntervalo.listaIntervalo.Item(i)._valor = fMax) Then
                        limInf_modal = ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior
                        ListaGrafica.listaGrafica.Item(id_grafica)._intervaloMo = getLimites(i)

                        Try
                            fant_Mod = ListaIntervalo.listaIntervalo.Item(i - 1)._valor
                        Catch ex As Exception
                            fant_Mod = 0
                        End Try
                        fsig_Mod = ListaIntervalo.listaIntervalo.Item(i + 1)._valor

                    End If
                Else
                    If (ListaIntervalo.listaIntervalo.Item(i)._valor = fMax) Then
                        limInf_modal = ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior
                        ListaGrafica.listaGrafica.Item(id_grafica)._intervaloMo = getLimites(i)

                        Try
                            fant_Mod = ListaIntervalo.listaIntervalo.Item(i - 1)._valor
                        Catch ex As Exception
                            fant_Mod = 0
                        End Try

                        fsig_Mod = ListaIntervalo.listaIntervalo.Item(i + 1)._valor
                    End If
                End If

            Else
                'MODA - limInf(maxFrec) - f(maxFrec) - f_1(ant_maxFrec) - f-1(sig_maxFrec) amp
                'liminf+((f - f_1) / (f - f_1) + (f - f-1)) * amp
                amp = ListaGrafica.listaGrafica.Item(id_grafica)._amplitud
                Mo = limInf_modal + ((fMax - fant_Mod) / ((fMax - fant_Mod) + (fMax - fsig_Mod))) * amp

                ListaGrafica.listaGrafica.Item(id_grafica)._Fr = Fr
                ListaGrafica.listaGrafica.Item(id_grafica)._Ma = Ma
                ListaGrafica.listaGrafica.Item(id_grafica)._Mo = Mo

                N = Nothing
                f = Nothing
                Fr = Nothing
                auxFr = Nothing

                x = Nothing
                Ma = Nothing
                auxMa = Nothing

                limInf_modal = Nothing
                amp = Nothing
                fMax = Nothing
                fant_Mod = Nothing
                fsig_Mod = Nothing

                i -= 1
                id_grafica += 1
            End If
        Next
        'MODA - limInf(maxFrec) - f(maxFrec) - f_1(ant_maxFrec) - f-1(sig_maxFrec) amp
        'liminf+((f - f_1) / (f - f_1) + (f - f-1)) * amp
        amp = ListaGrafica.listaGrafica.Item(id_grafica)._amplitud
        Mo = limInf_modal + ((f - fant_Mod) / ((f - fant_Mod) + (f - fsig_Mod))) * amp

        ListaGrafica.listaGrafica.Item(id_grafica)._Fr = Fr
        ListaGrafica.listaGrafica.Item(id_grafica)._Ma = Ma
        ListaGrafica.listaGrafica.Item(id_grafica)._Mo = Mo

    End Sub

    Private Sub mediana()
        Dim id_grafica As Integer
        'Dim interMd As Integer

        Dim limInf As Single
        Dim N As Single
        Dim f As Integer
        Dim fa_ant As Integer
        Dim amp As Single
        Dim Md As Single

        Dim k As Integer

        For i As Integer = 0 To ListaIntervalo.listaIntervalo.Count - 1 Step 1
            If (ListaIntervalo.listaIntervalo.Item(i)._id_grafica = id_grafica) Then
                If (N = 0) Then
                    N = ListaGrafica.listaGrafica.Item(id_grafica)._N
                    N = N / 2
                End If

                If (ListaIntervalo.listaIntervalo.Item(i)._frecAcumulada > N) Then
                    limInf = ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior
                    fa_ant = ListaIntervalo.listaIntervalo.Item(i - 1)._frecAcumulada
                    f = ListaIntervalo.listaIntervalo.Item(i)._valor
                    amp = ListaGrafica.listaGrafica.Item(id_grafica)._amplitud

                    k = ListaGrafica.listaGrafica.Item(id_grafica)._k
                    i = i + (k - 3)

                    ListaGrafica.listaGrafica.Item(id_grafica)._intervaloMd = getLimites(i)
                End If
            Else
                Md = limInf + ((N - fa_ant) / f) * amp
                ListaGrafica.listaGrafica.Item(id_grafica)._Md = Md

                id_grafica += 1

                limInf = Nothing
                N = Nothing
                f = Nothing
                fa_ant = Nothing
                amp = Nothing
                Md = Nothing

                i -= 1
            End If
        Next
        Md = limInf + ((N - fa_ant) / f) * amp
        ListaGrafica.listaGrafica.Item(id_grafica)._Md = Md
    End Sub

    Private Function getLimites(i As Integer) As String
        Dim limites As String
        limites = ListaIntervalo.listaIntervalo.Item(i)._lim_Inferior & "-" & ListaIntervalo.listaIntervalo.Item(i)._lim_Superior

        Return limites
    End Function

End Class
