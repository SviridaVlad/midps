object Form1: TForm1
  Left = 195
  Top = 172
  Width = 296
  Height = 301
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
    Left = 40
    Top = 20
    Width = 90
    Height = 13
    Caption = 'Svirida Vlad TI-145'
  end
  object Button1: TButton
    Left = 16
    Top = 136
    Width = 75
    Height = 25
    Caption = 'Stop'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 16
    Top = 100
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 1
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 12
    Top = 172
    Width = 75
    Height = 25
    Caption = 'Reset'
    TabOrder = 2
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 112
    Top = 200
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 3
    OnClick = Button4Click
  end
  object Edit1: TEdit
    Left = 112
    Top = 136
    Width = 121
    Height = 21
    TabOrder = 4
    Text = '00:00:00'
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 232
    Top = 204
  end
end
