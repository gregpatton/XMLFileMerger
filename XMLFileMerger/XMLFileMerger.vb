Imports System.IO
Imports System.Xml

Public Class frmXMLFileMerger

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdMergeXML.Click
        Try
            Dim xmlreader1 As New XmlTextReader(txtInput1.Text)
            Dim xmlreader2 As New XmlTextReader(txtInput2.Text)

            Dim ds1 As New DataSet()
            ds1.ReadXml(xmlreader1)

            Dim ds2 As New DataSet()
            ds2.ReadXml(xmlreader2)

            ds1.Merge(ds2)
            ds1.WriteXml(txtOutput.Text, XmlWriteMode.IgnoreSchema)

            MsgBox("Completed merging XML documents", MsgBoxStyle.Information, "XML Merger Complete")
        
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
