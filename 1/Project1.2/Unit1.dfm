object Form1: TForm1
  Left = 659
  Top = 225
  Width = 533
  Height = 430
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 276
    Top = 56
    Width = 127
    Height = 13
    Caption = 'Grafic   Svirida Vlad TI-145'
  end
  object PaintBox1: TPaintBox
    Left = 184
    Top = 92
    Width = 305
    Height = 233
    OnPaint = PaintBox1Paint
  end
  object Button1: TButton
    Left = 12
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Panel1: TPanel
    Left = 128
    Top = 116
    Width = 29
    Height = 97
    Color = clBackground
    TabOrder = 1
  end
  object Panel2: TPanel
    Left = 128
    Top = 212
    Width = 29
    Height = 121
    Color = clBlue
    TabOrder = 2
  end
  object Button2: TButton
    Left = 12
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 3
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 12
    Top = 208
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 4
    OnClick = Button3Click
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 364
    Top = 344
  end
end
