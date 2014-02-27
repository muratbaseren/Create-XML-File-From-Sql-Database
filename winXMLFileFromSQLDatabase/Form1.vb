#Region "Imports"
Imports System.Xml
#End Region

Public Class Form1

#Region "Local Variables"
    Private ConnStr As String = ""
    Private lstLeft As ListBox
    Private lstRight As ListBox
    Private lstFocus As String
    Private tpList As ArrayList = New ArrayList
#End Region

#Region "Methods"
    Private Sub UserControl1_AllLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not lstRight.Items.Count = 0 Then
            For i As Integer = 0 To lstRight.Items.Count - 1
                lstLeft.Items.Add(lstRight.Items(0).ToString)
                lstRight.Items.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub UserControl1_AllRight_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not lstLeft.Items.Count = 0 Then
            For i As Integer = 0 To lstLeft.Items.Count - 1
                lstRight.Items.Add(lstLeft.Items(0).ToString)
                lstLeft.Items.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub UserControl1_OneLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not lstRight.SelectedIndex = -1 Then
            Dim Index As Integer = lstRight.SelectedIndex
            lstLeft.Items.Add(lstRight.SelectedItem.ToString)
            lstRight.Items.RemoveAt(lstRight.SelectedIndex)
            If Not lstRight.Items.Count = 0 Then
                If lstRight.Items.Count = Index AndAlso (lstRight.Items.Count <> 1 OrElse lstRight.Items.Count = 1) Then
                    lstRight.SelectedIndex = Index - 1
                Else
                    lstRight.SelectedIndex = Index
                End If
            End If
        End If
    End Sub

    Private Sub UserControl1_OneRight_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not lstLeft.SelectedIndex = -1 Then
            Dim Index As Integer = lstLeft.SelectedIndex
            lstRight.Items.Add(lstLeft.SelectedItem.ToString)
            lstLeft.Items.RemoveAt(lstLeft.SelectedIndex)
            If Not lstLeft.Items.Count = 0 Then
                If lstLeft.Items.Count = Index AndAlso (lstLeft.Items.Count <> 1 OrElse lstLeft.Items.Count = 1) Then
                    lstLeft.SelectedIndex = Index - 1
                Else
                    lstLeft.SelectedIndex = Index
                End If
            End If
        End If
    End Sub

    Private Sub GetData(ByVal tp As TabPage)
        'ListBoxToWave(Me.tbcTables.SelectedIndex)

        If Not Me.tbcTables.TabPages.Count = 0 Then
            For Each ctrl As Control In tp.Controls
                If TypeOf ctrl Is ListBox Then
                    If CType(ctrl, ListBox).Name = "lstElement" Then
                        lstLeft = CType(ctrl, ListBox)
                    ElseIf CType(ctrl, ListBox).Name = "lstAttribute" Then
                        lstRight = CType(ctrl, ListBox)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub lstLeftFocus(ByVal sender As Object, ByVal e As EventArgs)
        Me.lstFocus = "lstLeft"
    End Sub

    Private Sub lstRightFocus(ByVal sender As Object, ByVal e As EventArgs)
        Me.lstFocus = "lstRight"
    End Sub
#End Region

#Region "SQL"
    Private Sub rdbWindowsAut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWindowsAut.CheckedChanged
        If Me.rdbWindowsAut.Checked Then
            Me.pnlAut.Enabled = False
        End If
    End Sub

    Private Sub rdbSqlAut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSqlAut.CheckedChanged
        If Me.rdbSqlAut.Checked Then
            Me.pnlAut.Enabled = True
        End If
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Dim DP As DataProccess = New DataProccess
        Dim DT As DataTable = New DataTable

        If Me.rdbSqlAut.Checked Then
            'SQL Aut. seçildiyse..
            If Me.txtServer.Text <> "" AndAlso Me.txtUserID.Text <> "" AndAlso Me.txtPassword.Text <> "" Then
                ConnStr = "Data Source=" & Me.txtServer.Text & ";Initial Catalog=Master;User Id=" & Me.txtUserID.Text & ";Password=" & Me.txtPassword.Text & ";"
            Else
                'SQL Aut. 'da server,þifre yada UserID boþ býrakýlýrsa..
                MessageBox.Show("Server ,UserID ve Password alanlarýný kullanarak SQL Authentication baðlantý yapýnýz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Else
            'Windows aut. seçildiyse..
            ConnStr = "Data Source=" & Me.txtServer.Text & ";Initial Catalog=Master;Integrated Security=SSPI;"
        End If
        'Sorgu ile datatable þeklinde database isimleri döndürülür.
        DT = DP.SelectQuery(ConnStr, "SELECT name FROM sysdatabases WHERE sid<>0x01")

        'Database combobox 'ý temizlenip database isimleri doldurulur.
        Me.cmbDatabases.Items.Clear()
        For i As Integer = 0 To DT.Rows.Count - 1
            Me.cmbDatabases.Items.Add(DT.Rows(i)(0).ToString)
        Next

        'Eðer database varsa en baþtaki seçilir.
        If Not Me.cmbDatabases.Items.Count = 0 Then
            Me.cmbDatabases.SelectedIndex = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtServer.Text = My.Computer.Name.ToString
    End Sub

    Private Sub cmbDatabases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDatabases.SelectedIndexChanged
        If Not Me.cmbDatabases.SelectedIndex = -1 Then
            Dim DP As DataProccess = New DataProccess
            Dim DT As DataTable = New DataTable

            'Seçilen database içindeki tablo isimleri okunur.
            DT = DP.SelectQuery(ConnStr, "SELECT name FROM " & Me.cmbDatabases.SelectedItem.ToString & ".dbo.sysobjects WHERE xtype='U' AND name<>'sysdiagrams'")

            'Tablolar Datatable 'dan okunarak CheckedListBox 'a aktarýlýr.
            Me.clbTables.Items.Clear()
            For i As Integer = 0 To DT.Rows.Count - 1
                Me.clbTables.Items.Add(DT.Rows(i)(0).ToString)
            Next

        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click

        For i As Integer = 0 To Me.clbTables.CheckedItems.Count - 1
            Dim TableAttribute(3) As String
            'Server bilgisi..
            TableAttribute(0) = Me.txtServer.Text
            'Database bilgisi..
            TableAttribute(1) = Me.cmbDatabases.SelectedItem.ToString
            'Table bilgisi..
            TableAttribute(2) = Me.clbTables.CheckedItems(i).ToString
            'ConnectionString bilgisi..
            TableAttribute(3) = ConnStr

            'TabPage oluþturulur..
            Dim tp As TabPage = New TabPage
            tp.Name = TableAttribute(2)
            tp.Tag = TableAttribute
            tp.Text = TableAttribute(1) & "-" & TableAttribute(2)

            Dim IsCreateTable As Boolean = False
            'Seçilen tablonun TabPage 'i önceden oluþturuldumu kontrolu..
            If Not tpList.Count = 0 Then
                For y As Integer = 0 To tpList.Count - 1
                    If tpList(y).ToString = tp.Text Then
                        IsCreateTable = True
                    End If
                Next
            End If

            If Not IsCreateTable = True Then
                tp.AutoScroll = True
                tp.Padding = New Windows.Forms.Padding(8)

                '==============================
                'Label'lar Eklenir..
                '==============================
                For t As Integer = 0 To 1
                    Dim lbl As Label = New Label
                    Select Case t
                        Case 0
                            lbl.Name = "lblAttribute"
                            lbl.Text = "Attribute"
                        Case 1
                            lbl.Name = "lblElement"
                            lbl.Text = "Element"
                    End Select
                    lbl.TextAlign = ContentAlignment.MiddleCenter
                    lbl.Font = New Font("Verdana", 10, FontStyle.Underline)
                    lbl.ForeColor = Color.Brown
                    lbl.Width = 80
                    tp.Controls.Add(lbl)
                    lbl.Dock = DockStyle.Left
                    If lbl.Name = "lblAttribute" Then
                        '==============================
                        'Listbox'lar Eklenir..
                        '==============================
                        For k As Integer = 0 To 1
                            Dim lst As ListBox = New ListBox
                            Select Case k
                                Case 0
                                    lst.Name = "lstAttribute"
                                    AddHandler lst.MouseHover, AddressOf lstRightFocus
                                Case 1
                                    lst.Name = "lstElement"
                                    AddHandler lst.MouseHover, AddressOf lstLeftFocus
                            End Select
                            lst.ContextMenuStrip = Me.cmnuListboxes
                            lst.Items.Clear()
                            lst.Width = 150
                            tp.Controls.Add(lst)
                            lst.Dock = DockStyle.Left
                            If lst.Name = "lstElement" Then
                                Dim DT As DataTable = New DataTable
                                Dim DP As DataProccess = New DataProccess
                                'Tablodaki kolon isimlerinin çekilmesi..
                                DT = DP.SelectQuery(ConnStr, "SELECT name FROM " & TableAttribute(1) & ".dbo.syscolumns WHERE id=object_id('" & TableAttribute(1) & ".dbo." & TableAttribute(2) & "')")
                                'Tablodaki kolon isimlerinin Element 
                                'ListBox() 'ýna dolmasý..
                                For j As Integer = 0 To DT.Rows.Count - 1
                                    lst.Items.Add(DT.Rows(j)(0).ToString)
                                Next
                            ElseIf lst.Name = "lstAttribute" Then
                                '==============================
                                'UserControl Eklenir..
                                '==============================
                                Dim ctrl As UserControl1 = New UserControl1
                                ctrl.Name = "UserControl1"
                                tp.Controls.Add(ctrl)
                                ctrl.Dock = DockStyle.Left
                                AddHandler ctrl.AllRight_Click, AddressOf UserControl1_AllRight_Click
                                AddHandler ctrl.AllLeft_Click, AddressOf UserControl1_AllLeft_Click
                                AddHandler ctrl.OneRight_Click, AddressOf UserControl1_OneRight_Click
                                AddHandler ctrl.OneLeft_Click, AddressOf UserControl1_OneLeft_Click
                                '========AddUserControlEnd=====
                            End If
                        Next
                        '=========AddListboxEnd=======
                    End If
                Next
                '===========AddLabelEnd========
                Me.tbcTables.TabPages.Add(tp)
            End If

        Next

        tpList.Clear()
        For Each tp As TabPage In Me.tbcTables.TabPages
            tpList.Add(tp.Text)
        Next

        If Not Me.tbcTables.TabPages.Count = 0 Then
            GetData(Me.tbcTables.TabPages(0))
        End If
    End Sub

    Private Sub tbcTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcTables.SelectedIndexChanged
        GetData(Me.tbcTables.SelectedTab)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Not Me.tbcTables.TabPages.Count = 0 Then
            If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                For i As Integer = 0 To Me.tbcTables.TabPages.Count - 1
                    GetData(tbcTables.TabPages(i))
                    Dim TableAttribute() As String
                    TableAttribute = CType(Me.tbcTables.TabPages(i).Tag, String())

                    Dim List1 As String = ""
                    Dim XTW As XmlTextWriter
                    If Not lstLeft.Items.Count = 0 OrElse Not lstRight.Items.Count = 0 Then
                        XTW = New XmlTextWriter(Me.FolderBrowserDialog1.SelectedPath & "\" & TableAttribute(1) & "." & TableAttribute(2) & ".xml", System.Text.Encoding.GetEncoding("ISO-8859-9"))

                        XTW.WriteStartDocument()
                        XTW.Formatting = Formatting.Indented

                        'Root tag..
                        XTW.WriteStartElement("Table")
                        XTW.WriteAttributeString("TableName", TableAttribute(2))
                        XTW.WriteAttributeString("Server", TableAttribute(0))
                        XTW.WriteAttributeString("Database", TableAttribute(1))
                        XTW.WriteAttributeString("ConnectionString", TableAttribute(3))

                        If Not Me.lstLeft.Items.Count = 0 Then
                            For k As Integer = 0 To lstLeft.Items.Count - 1
                                List1 &= lstLeft.Items(k).ToString & ","
                            Next
                        End If

                        Dim List2 As String = ""
                        If Not lstRight.Items.Count = 0 Then
                            For j As Integer = 0 To lstRight.Items.Count - 1
                                List2 &= lstRight.Items(j).ToString & ","
                            Next
                            List2 = List2.Remove(List2.Length - 1, 1)
                        Else
                            List1 = List1.Remove(List1.Length - 1, 1)
                        End If

                        Dim Sorgu As String = "SELECT " & List1 & List2 & " FROM " & TableAttribute(1) & ".dbo." & TableAttribute(2)
                        Dim DT As DataTable = New DataTable
                        Dim DP As DataProccess = New DataProccess
                        DT = DP.SelectQuery(TableAttribute(3), Sorgu)

                        For p As Integer = 0 To DT.Rows.Count - 1
                            XTW.WriteStartElement("TableRow")
                            XTW.WriteAttributeString("RowID", p)
                            For m As Integer = DT.Columns.Count - 1 To 0 Step -1
                                'XTW.WriteElementString(DT.Columns(m).Caption.ToString, DT.Rows(p)(m).ToString)
                                If m < lstLeft.Items.Count Then
                                    XTW.WriteElementString(DT.Columns(m).Caption.ToString, DT.Rows(p)(m).ToString)
                                Else
                                    XTW.WriteAttributeString(DT.Columns(m).Caption.ToString, DT.Rows(p)(m).ToString)
                                End If
                            Next
                            XTW.WriteEndElement()
                        Next

                        XTW.WriteEndElement()

                        XTW.WriteEndDocument()
                        XTW.Close()
                    ElseIf lstLeft.Items.Count = 0 AndAlso lstRight.Items.Count = 0 Then
                        MessageBox.Show(TableAttribute(2) & " adlý tabloda Element yada Attribute listelerinizden biri yada ikisinde de kolon mevcut deðil..Lütfen bu tablodan XML oluþturmak için kolon ekleyiniz..", TableAttribute(2) & " Tablosunun Kolonu Yok !", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        For Each tp As TabPage In Me.tbcTables.TabPages
            tp.Dispose()
        Next
    End Sub

    Private Sub cmnuTCTableClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTCTableClose.Click
        Me.tbcTables.SelectedTab.Dispose()
    End Sub

    Private Sub cmnuLstColumnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLstColumnDel.Click
        If Me.lstFocus = "lstLeft" Then
            If Not Me.lstLeft.SelectedIndex = -1 Then
                Me.lstLeft.Items.RemoveAt(Me.lstLeft.SelectedIndex)
            End If
        Else
            If Not Me.lstRight.SelectedIndex = -1 Then
                Me.lstRight.Items.RemoveAt(Me.lstRight.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub cmnulstAllColumns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnulstAllColumns.Click
        Me.lstLeft.Items.Clear()
        Me.lstRight.Items.Clear()

        Dim TableAttribute(3) As String
        TableAttribute = Me.tbcTables.SelectedTab.Tag
        Dim DT As DataTable = New DataTable
        Dim DP As DataProccess = New DataProccess
        'Tablodaki kolon isimlerinin çekilmesi..
        DT = DP.SelectQuery(TableAttribute(3), "SELECT name FROM " & TableAttribute(1) & ".dbo.syscolumns WHERE id=object_id('" & TableAttribute(1) & ".dbo." & TableAttribute(2) & "')")
        'Tablodaki kolon isimlerinin Element 
        'ListBox() 'ýna dolmasý..
        For j As Integer = 0 To DT.Rows.Count - 1
            lstLeft.Items.Add(DT.Rows(j)(0).ToString)
        Next
    End Sub

    Private Sub cmnuLstMoveToUpColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLstMoveToUpColumn.Click
        If Me.lstFocus = "lstLeft" Then
            If Not Me.lstLeft.SelectedIndex = -1 Then
                If Not Me.lstLeft.SelectedIndex = 0 Then
                    Me.lstLeft.Items.Insert(Me.lstLeft.SelectedIndex - 1, Me.lstLeft.SelectedItem.ToString)
                    Me.lstLeft.SelectedIndex = Me.lstLeft.SelectedIndex - 2
                    Me.lstLeft.Items.RemoveAt(Me.lstLeft.SelectedIndex + 2)
                End If
            End If
        Else
            If Not Me.lstRight.SelectedIndex = -1 Then
                If Not Me.lstRight.SelectedIndex = 0 Then
                    Me.lstRight.Items.Insert(Me.lstRight.SelectedIndex - 1, Me.lstRight.SelectedItem.ToString)
                    Me.lstRight.SelectedIndex = Me.lstRight.SelectedIndex - 2
                    Me.lstRight.Items.RemoveAt(Me.lstRight.SelectedIndex + 2)
                End If
            End If
        End If
    End Sub

    Private Sub cmnulstAllColumnsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnulstAllColumnsDel.Click
        If Me.lstFocus = "lstLeft" Then
            Me.lstLeft.Items.Clear()
        Else
            Me.lstRight.Items.Clear()
        End If
    End Sub

    Private Sub cmnuLstMoveToDownColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLstMoveToDownColumn.Click
        If Me.lstFocus = "lstLeft" Then
            If Not Me.lstLeft.SelectedIndex = -1 Then
                If Not Me.lstLeft.SelectedIndex = Me.lstLeft.Items.Count - 1 Then
                    Me.lstLeft.Items.Insert(Me.lstLeft.SelectedIndex + 2, Me.lstLeft.SelectedItem.ToString)
                    Me.lstLeft.SelectedIndex = Me.lstLeft.SelectedIndex + 2
                    Me.lstLeft.Items.RemoveAt(Me.lstLeft.SelectedIndex - 2)
                End If
            End If
        Else
            If Not Me.lstRight.SelectedIndex = -1 Then
                If Not Me.lstRight.SelectedIndex = Me.lstRight.Items.Count - 1 Then
                    Me.lstRight.Items.Insert(Me.lstRight.SelectedIndex + 2, Me.lstRight.SelectedItem.ToString)
                    Me.lstRight.SelectedIndex = Me.lstRight.SelectedIndex + 2
                    Me.lstRight.Items.RemoveAt(Me.lstRight.SelectedIndex - 2)
                End If
            End If
        End If
    End Sub

    Private Sub cmnuTCCloseAllTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTCCloseAllTables.Click
        For Each tp As TabPage In Me.tbcTables.TabPages
            tp.Dispose()
        Next
    End Sub

    Private Sub cmnuTCClosAllTablesButThis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTCClosAllTablesButThis.Click
        For i As Integer = Me.tbcTables.TabPages.Count - 1 To 0 Step -1
            If Not i = Me.tbcTables.SelectedIndex Then
                Me.tbcTables.TabPages(i).Dispose()
            End If
        Next
    End Sub

    Private Sub DeselectAllTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeselectAllTables.Click
        For i As Integer = 0 To Me.clbTables.Items.Count - 1
            Me.clbTables.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub SelectAllTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllTables.Click
        For i As Integer = 0 To Me.clbTables.Items.Count - 1
            Me.clbTables.SetItemChecked(i, True)
        Next
    End Sub
#End Region

#Region "Access"
    '=========================================================
    'Access
    '=========================================================

    '    Private Sub btnAccOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccOpen.Click
    '        Me.OpenFileDialog1.Filter = "Microsoft Office Access Application(*.mdb)|*.mdb"
    '        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Me.txtAccDatabasePath.Text = Me.OpenFileDialog1.FileName.ToString
    '        End If
    '    End Sub

    '    Private Sub btnAccConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccConnect.Click
    '        Dim DP As DataProccess
    '        Dim DT As DataTable

    '        If Not Me.txtAccDatabasePath.Text = Nothing Then
    '            DP = New DataProccess(False)
    '            DT = New DataTable

    '            ConnStrAcc = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Me.txtAccDatabasePath.Text & ";"

    '            Me.clbTables.Items.Clear()

    '            'Seçilen database içindeki tablo isimleri okunur.
    '            DT = DP.ACCESSSelectQuery(ConnStrAcc, "SELECT * FROM Tablolar")

    '            'Tablolar Datatable 'dan okunarak CheckedListBox 'a aktarýlýr.
    '            Me.clbTables.Items.Clear()
    '            For i As Integer = 0 To DT.Rows.Count - 1
    '                Me.clbTables.Items.Add(DT.Rows(i)(0).ToString)
    '            Next

    '        Else
    '            MessageBox.Show("Lütfen bir Access Database dosyasý seçiniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        End If
    '    End Sub

    '    Private Sub tsbAccNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAccNew.Click
    '        For Each tp As TabPage In Me.tbcAccXML.TabPages
    '            tp.Dispose()
    '        Next
    '    End Sub

    '    Private Sub tsbAccOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAccOpen.Click
    '        For i As Integer = 0 To Me.clbTables.CheckedItems.Count - 1
    '            Dim TableAttribute(2) As String
    '            'Database konumu..
    '            TableAttribute(0) = Me.txtAccDatabasePath.Text.Substring(Me.txtAccDatabasePath.Text.LastIndexOf("\") + 1, Me.txtAccDatabasePath.Text.LastIndexOf(".") - Me.txtAccDatabasePath.Text.LastIndexOf("\"))
    '            'Table bilgisi..
    '            TableAttribute(1) = Me.clbTables.CheckedItems(i).ToString
    '            'ConnectionString bilgisi..
    '            TableAttribute(2) = ConnStrAcc

    '            'TabPage oluþturulur..
    '            Dim tp As TabPage = New TabPage
    '            tp.Name = TableAttribute(1)
    '            tp.Tag = TableAttribute
    '            tp.Text = TableAttribute(0) & "-" & TableAttribute(1)

    '            Dim IsCreateTable As Boolean = False
    '            'Seçilen tablonun TabPage 'i önceden oluþturuldumu kontrolu..
    '            If Not tpList.Count = 0 Then
    '                For y As Integer = 0 To tpList.Count - 1
    '                    If tpList(y).ToString = tp.Text Then
    '                        IsCreateTable = True
    '                    End If
    '                Next
    '            End If

    '            If Not IsCreateTable = True Then
    '                tp.AutoScroll = True
    '                tp.Padding = New Windows.Forms.Padding(8)

    '                '==============================
    '                'Label'lar Eklenir..
    '                '==============================
    '                For t As Integer = 0 To 1
    '                    Dim lbl As Label = New Label
    '                    Select Case t
    '                        Case 0
    '                            lbl.Name = "lblAttribute"
    '                            lbl.Text = "Attribute"
    '                        Case 1
    '                            lbl.Name = "lblElement"
    '                            lbl.Text = "Element"
    '                    End Select
    '                    lbl.TextAlign = ContentAlignment.MiddleCenter
    '                    lbl.Font = New Font("Verdana", 10, FontStyle.Underline)
    '                    lbl.ForeColor = Color.Brown
    '                    lbl.Width = 80
    '                    tp.Controls.Add(lbl)
    '                    lbl.Dock = DockStyle.Left
    '                    If lbl.Name = "lblAttribute" Then
    '                        '==============================
    '                        'Listbox'lar Eklenir..
    '                        '==============================
    '                        For k As Integer = 0 To 1
    '                            Dim lst As ListBox = New ListBox
    '                            Select Case k
    '                                Case 0
    '                                    lst.Name = "lstAttribute"
    '                                    AddHandler lst.MouseHover, AddressOf lstRightFocus
    '                                Case 1
    '                                    lst.Name = "lstElement"
    '                                    AddHandler lst.MouseHover, AddressOf lstLeftFocus
    '                            End Select
    '                            lst.ContextMenuStrip = Me.cmnuListboxes
    '                            lst.Items.Clear()
    '                            lst.Width = 150
    '                            tp.Controls.Add(lst)
    '                            lst.Dock = DockStyle.Left
    '                            If lst.Name = "lstElement" Then
    '                                Dim DT As DataTable = New DataTable
    '                                Dim DP As DataProccess = New DataProccess(False)
    '                                'Tablodaki kolon isimlerinin çekilmesi..
    '                                DT = DP.ACCESSSelectQuery(ConnStrSQL, "SELECT * FROM " & TableAttribute(1))
    '                                'Tablodaki kolon isimlerinin Element 
    '                                'ListBox() 'ýna dolmasý..
    '                                For j As Integer = 0 To DT.Rows.Count - 1
    '                                    lst.Items.Add(DT.Rows(j)(0).ToString)
    '                                Next
    '                            ElseIf lst.Name = "lstAttribute" Then
    '                                '==============================
    '                                'UserControl Eklenir..
    '                                '==============================
    '                                Dim ctrl As UserControl1 = New UserControl1
    '                                ctrl.Name = "UserControl1"
    '                                tp.Controls.Add(ctrl)
    '                                ctrl.Dock = DockStyle.Left
    '                                AddHandler ctrl.AllRight_Click, AddressOf UserControl1_AllRight_Click
    '                                AddHandler ctrl.AllLeft_Click, AddressOf UserControl1_AllLeft_Click
    '                                AddHandler ctrl.OneRight_Click, AddressOf UserControl1_OneRight_Click
    '                                AddHandler ctrl.OneLeft_Click, AddressOf UserControl1_OneLeft_Click
    '                                '========AddUserControlEnd=====
    '                            End If
    '                        Next
    '                        '=========AddListboxEnd=======
    '                    End If
    '                Next
    '                '===========AddLabelEnd========
    '                Me.tbcTables.TabPages.Add(tp)
    '            End If

    '        Next

    '        tpList.Clear()
    '        For Each tp As TabPage In Me.tbcTables.TabPages
    '            tpList.Add(tp.Text)
    '        Next

    '        If Not Me.tbcTables.TabPages.Count = 0 Then
    '            GetData(Me.tbcTables.TabPages(0))
    '        End If
    '    End Sub
    '#End Region
#End Region
    
End Class
