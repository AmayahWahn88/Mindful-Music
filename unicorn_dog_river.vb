Option Explicit

Public Class MindfulMusic
    Private PropertyTitle As String
    Private PropertyArtist As String
    Private PropertyDuration As Integer
    Private PropertyGenre As String
    Private PropertyTrackNumber As Integer
    Private PropertySize As Double
    Private PropertyReleaseDate As Date
    Private PropertyIsPlaying As Boolean
    Private PropertyHasLyrics As Boolean
    Private PropertyLyrics As String
    Private PropertyFreeDownload As Boolean
    Private PropertyFileType As String
    Private PropertyRating As Integer
    Private PropertyIsFree As Boolean
    Private PropertyPrice As Double
    Private PropertyInstrumental As Boolean
    Public Sub New(ByVal title As String, ByVal artist As String, ByVal duration As Integer, ByVal genre As String, ByVal tracknumber As Integer, _
                  ByVal size As Double, ByVal releaseDate As Date, ByVal isPlaying As Boolean, ByVal hasLyrics As Boolean, _
                  ByVal lyrics As String, ByVal freeDownload As Boolean, ByVal fileType As String, _
                  ByVal rating As Integer, ByVal isFree As Boolean, ByVal price As Double, ByVal instrumental As Boolean)
        Me.PropertyTitle = title
        Me.PropertyArtist = artist
        Me.PropertyDuration = duration
        Me.PropertyGenre = genre
        Me.PropertyTrackNumber = tracknumber
        Me.PropertySize = size
        Me.PropertyReleaseDate = releaseDate
        Me.PropertyIsPlaying = isPlaying
        Me.PropertyHasLyrics = hasLyrics
        Me.PropertyLyrics = lyrics
        Me.PropertyFreeDownload = freeDownload
        Me.PropertyFileType = fileType
        Me.PropertyRating = rating
        Me.PropertyIsFree = isFree
        Me.PropertyPrice = price
        Me.PropertyInstrumental = instrumental
    End Sub
    Public Function GetTitle() As String
        GetTitle = Me.PropertyTitle
    End Function
    Public Function GetArtist() As String
        GetArtist = Me.PropertyArtist
    End Function
    Public Function GetDuration() As Integer
        GetDuration = Me.PropertyDuration
    End Function
    Public Function GetGenre() As String
        GetGenre = Me.PropertyGenre
    End Function
    Public Function GetTrackNumber() As Integer
        GetTrackNumber = Me.PropertyTrackNumber
    End Function
    Public Function GetSize() As Double
        GetSize = Me.PropertySize
    End Function
    Public Function GetReleaseDate() As Date
        GetReleaseDate = Me.PropertyReleaseDate
    End Function
    Public Function IsPlaying() As Boolean
        IsPlaying = Me.PropertyIsPlaying
    End Function
    Public Function HasLyrics() As Boolean
        HasLyrics = Me.PropertyHasLyrics
    End Function
    Public Function GetLyrics() As String
        GetLyrics = Me.PropertyLyrics
    End Function
    Public Function IsFreeDownload() As Boolean
        IsFreeDownload = Me.PropertyFreeDownload
    End Function
    Public Function GetFileType() As String
        GetFileType = Me.PropertyFileType
    End Function
    Public Function GetRating() As Integer
        GetRating = Me.PropertyRating
    End Function
    Public Function IsFree() As Boolean
        IsFree = Me.PropertyIsFree
    End Function
    Public Function GetPrice() As Double
        GetPrice = Me.PropertyPrice
    End Function
    Public Function IsInstrumental() As Boolean
        IsInstrumental = Me.PropertyInstrumental
    End Function
    Public Sub PlayMusic()
        Me.PropertyIsPlaying = True
    End Sub
    Public Sub StopMusic()
        Me.PropertyIsPlaying = False
    End Sub
    Public Sub SetLyrics(ByVal lyrics As String)
        Me.PropertyLyrics = lyrics
    End Sub
    Public Sub SetFreeDownload(ByVal free As Boolean)
        Me.PropertyFreeDownload = free
    End Sub
    Public Sub SetFileType(ByVal fileType As String)
        Me.PropertyFileType = fileType
    End Sub
    Public Sub SetRating(ByVal rating As Integer)
        Me.PropertyRating = rating
    End Sub
    Public Sub SetIsFree(ByVal isFree As Boolean)
        Me.PropertyIsFree = isFree
    End Sub
    Public Sub SetPrice(ByVal price As Double)
        Me.PropertyPrice = price
    End Sub
    Public Sub SetInstrumental(ByVal instrumental As Boolean)
        Me.PropertyInstrumental = instrumental
    End Sub
End Class