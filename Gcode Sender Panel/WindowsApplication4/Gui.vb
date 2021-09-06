Option Explicit On
Option Infer Off
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO



Public Class Gui
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String) 'mencegah error thread saat menerima data
    Dim instruksi As Boolean = True



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames() 'Otomatis terdeteksi COM Port yang telah tersedia pada Device Manager
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False


        Try
            ComboBoxCOM.Items.AddRange(myPort)
            ButtonDisconnect.Enabled = False
            'System.Threading.Thread.Sleep(1000)
            Button3.Enabled = False
            ButtonStart.Enabled = False
            ButtonStop.Enabled = False
            ButtonHome.Enabled = False
            SetHome.Enabled = False
            SpindleOn.Enabled = False
            SpindleOff.Enabled = False
            ButtonXright.Enabled = False
            ButtonXleft.Enabled = False
            ButtonYforw.Enabled = False
            ButtonYrev.Enabled = False
            ButtonZup.Enabled = False
            Button4Zdown.Enabled = False
            TrackBar1.Enabled = False
            Button2.Enabled = False
            Button5.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            SerialPort1.WriteLine(TextBox2.Text)
            Label6.Text = "Sedang Berjalan"
            '     RichTextBox1.Text = SerialPort1.ReadLine()
            instruksi = False

        Catch ex As Exception
            MessageBox.Show("Theres No Command in Text Box")
        End Try
    End Sub
    'Tombol Koneksi sebelum Menyambungkan ke Ardiuino Board
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click      
        Try
            SerialPort1.PortName = ComboBoxCOM.Text
            SerialPort1.BaudRate = ComboBoxBaud.Text
            SerialPort1.Open()
            If SerialPort1.IsOpen() Then
                ButtonConnect.Enabled = False
                ButtonDisconnect.Enabled = True
                PictureBox1.BackColor = Color.DarkOliveGreen
                'Tombol jadi aktif setelah terkoneksi
                Button3.Enabled = True
                ButtonStart.Enabled = True
                ButtonStop.Enabled = True
                ButtonHome.Enabled = True
                SetHome.Enabled = True
                SpindleOn.Enabled = True
                SpindleOff.Enabled = True
                ButtonXright.Enabled = True
                ButtonXleft.Enabled = True
                ButtonYforw.Enabled = True
                ButtonYrev.Enabled = True
                ButtonZup.Enabled = True
                Button4Zdown.Enabled = True
                Button5.Enabled = True
                Button2.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show("Check Your Port Conection Again")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Mengload File yang diinginkan, harus dengan ektensi .gcode, .ngc atau .DXF, .txt file juga bisa tetapi harus berisi kode Gcode
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt|CNC Files (*.nc)|*.nc|Gcode Files (*.gcode)|*.gcode|DXF Drawing (*.DXF)|*.DXF"
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.Title = " "
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox3.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        'Tombol untuk Memutus Koneksi ke Board
        SerialPort1.Close()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = True
        PictureBox1.BackColor = Color.Red
        'Disable seluruh tombol
        Button3.Enabled = False
        ButtonStart.Enabled = False
        ButtonStop.Enabled = False
        ButtonHome.Enabled = False
        SetHome.Enabled = False
        SpindleOn.Enabled = False
        SpindleOff.Enabled = False
        ButtonXright.Enabled = False
        ButtonXleft.Enabled = False
        ButtonYforw.Enabled = False
        ButtonYrev.Enabled = False
        ButtonZup.Enabled = False
        Button4Zdown.Enabled = False
        TrackBar1.Enabled = False
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        SerialPort1.WriteLine("G28")
    End Sub

    Private Sub SetHome_Click(sender As Object, e As EventArgs) Handles SetHome.Click
        SerialPort1.WriteLine("G92")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AboutBox1.Show()
    End Sub

    Private Sub grDistance_Enter(sender As Object, e As EventArgs) Handles grDistance.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
    'Untuk Tombol Kontrol Manual Sumbu Y+
    Private Sub ButtonYforw_Click(sender As Object, e As EventArgs) Handles ButtonYforw.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y10 F1000")

        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y0.01 F500")
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y0.01 F1000")
        End If
    End Sub
    'Untuk Tombol Kontrol Manual Sumbu Y-
    Private Sub ButtonYrev_Click(sender As Object, e As EventArgs) Handles ButtonYrev.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y-10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y-10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y-10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y-10 F1000")
        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y-1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y-1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y-1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y-1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y-0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y-0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y-0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y-0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Y-0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Y-0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Y-0.01 F500")
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Y-0.01 F1000")
        End If
    End Sub
    'Untuk Tombol Kontrol Manual Sumbu X+
    Private Sub ButtonXleft_Click(sender As Object, e As EventArgs) Handles ButtonXleft.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X-10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X-10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X-10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X-10 F1000")
        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X-1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X-1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X-1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X-1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X-0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X-0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X-0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X-0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X-0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X-0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X-0.01 F500")
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X-0.01 F1000")
        End If
    End Sub
    'Untuk Tombol Kontrol Manual Sumbu X-
    Private Sub ButtonXright_Click(sender As Object, e As EventArgs) Handles ButtonXright.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X10 F1000")
        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 X0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 X0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 X0.01 F500")
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 X0.01 F1000")
        End If
    End Sub
    'Untuk Tombol Kontrol Manual Sumbu Z+
    Private Sub ButtonZup_Click(sender As Object, e As EventArgs) Handles ButtonZup.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z10 F1000")
        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z0.01 F500")
            RichTextBox1.Text = SerialPort1.ReadLine()
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z0.01 F1000")
        End If
    End Sub
    'Untuk Tombol Kontrol Manual Sumbu Z-
    Private Sub Button4Zdown_Click(sender As Object, e As EventArgs) Handles Button4Zdown.Click
        If RadioButton1.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z-10 F50")
        End If
        If RadioButton1.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z-10 F100")
        End If
        If RadioButton1.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z-10  F500")
        End If
        If RadioButton1.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z-10 F1000")
        End If
        If RadioButton2.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z-1 F50")
        End If
        If RadioButton2.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z-1 F100")
        End If
        If RadioButton2.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z-1 F500")
        End If
        If RadioButton2.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z-1 F1000")
        End If
        If RadioButton3.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z-0.1 F50")
        End If
        If RadioButton3.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z-0.1 F100")
        End If
        If RadioButton3.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z-0.1 F500")
        End If
        If RadioButton3.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z-0.1 F1000")
        End If
        If RadioButton4.Checked And Feed50.Checked Then
            SerialPort1.WriteLine("G1 Z-0.01 F50")
        End If
        If RadioButton4.Checked And Feed100.Checked Then
            SerialPort1.WriteLine("G1 Z-0.01 F100")
        End If
        If RadioButton4.Checked And Feed500.Checked Then
            SerialPort1.WriteLine("G1 Z-0.01 F500")
        End If
        If RadioButton4.Checked And Feed1000.Checked Then
            SerialPort1.WriteLine("G1 Z-0.01 F1000")
        End If
    End Sub
    Private Sub SpindleOn_Click(sender As Object, e As EventArgs) Handles SpindleOn.Click
        'Tombol Perintah Untuk Menyalakan Spindle yang Tersambung pada Board
        SerialPort1.WriteLine("M03 S" & TrackBar1.Value)
        SpindleOff.Enabled = True
        TrackBar1.Enabled = True
    End Sub

    Private Sub SpindleOff_Click(sender As Object, e As EventArgs) Handles SpindleOff.Click
        'Tombol Perintah Untuk Mematikan Spindle yang Tersambung pada Board
        SerialPort1.WriteLine("M05")
        TrackBar1.Enabled = False
        SpindleOn.Enabled = True
    End Sub

    Private Sub Radiomm_CheckedChanged(sender As Object, e As EventArgs) Handles Radiomm.CheckedChanged
        'Fitur Untuk Mengset Satuan Jarak pada putaran Stepper Metrik (milimeter)
        If Radiomm.Checked Then
            SerialPort1.WriteLine("G21")
        End If
    End Sub
   
    Private Sub RadioInch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioInch.CheckedChanged
        'Fitur Untuk Mengset Satuan Jarak pada putaran Stepper Imperial (Inch)
        If RadioInch.Checked Then
            SerialPort1.WriteLine("G20")
        End If
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'Trackbar untuk menyesuaikan Kecepatan pada Spindle motor (mata bor/engraver) tinggal Slide saja 
        Dim speed As Byte
        speed = TrackBar1.Value
        SerialPort1.WriteLine("M03 S" & TrackBar1.Value)
        TextBox1.Text = TrackBar1.Value

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        'Tombol Start untuk Mengirim File yang telah di Load pada Tombol *OpenFile*

        Try

            Dim objReader As New IO.StreamReader(Me.OpenFileDialog1.FileName)
            Do While objReader.Peek() >= 0
                Dim str As String
                If instruksi = True Then
                    str = objReader.ReadLine
                    RichTextBox1.Text = str
                    Label6.Text = "Sedang Berjalan"

                    SerialPort1.WriteLine(str)
                    instruksi = False
                    
                Else
                    Application.DoEvents()
                    'Thread.Sleep(1)
                End If
            Loop
        Catch ex As Exception
            MessageBox.Show("File Not Loaded")
        End Try

    End Sub
 

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        SerialPort1.WriteLine("M0")
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SerialPort1.Write(TextBox2.Text)
            TextBox2.Clear()
        End If
    End Sub


    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.AppendText(" " & vbNewLine)
        RichTextBox1.SelectionStart = Len(RichTextBox1.Text)
        RichTextBox1.ScrollToCaret()
        RichTextBox1.Select()

    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim pesan As String
        pesan = SerialPort1.ReadExisting
        RichTextBox1.Text &= pesan
        If pesan.Contains("@") = True Then
            instruksi = True
            Label6.Text = "Diterima"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.WriteLine("G90")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SerialPort1.WriteLine("G91")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub
End Class

