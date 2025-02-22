﻿' Copyright (C) 2022  Andy
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY
Namespace Plugin
    Public NotInheritable Class PropertyValue : Implements IPropertyValue
        Public Event ValueChanged As IPropertyValue.ValueChangedEventHandler Implements IPropertyValue.ValueChanged
        Public Property [Type] As Type Implements IPropertyValue.Type
        Public Property OnChangeFunction As IPropertyValue.ValueChangedEventHandler
        ''' <inheritdoc cref="PropertyValue.New(Object, Type, ByRef IPropertyValue.ValueChangedEventHandler)"/>
        ''' <exception cref="ArgumentNullException"></exception>
        Public Sub New(ByVal InitValue As Object)
            _Value = InitValue
            If IsNothing(InitValue) Then
                Throw New ArgumentNullException("InitValue", "InitValue cannot be null")
            Else
                [Type] = _Value.GetType
            End If
        End Sub
        ''' <inheritdoc cref="PropertyValue.New(Object, Type, ByRef IPropertyValue.ValueChangedEventHandler)"/>
        Public Sub New(ByVal InitValue As Object, ByVal T As Type)
            _Value = InitValue
            [Type] = T
        End Sub
        ''' <summary>New property value instance</summary>
        ''' <param name="InitValue">Initialization value</param>
        ''' <param name="T">Value type</param>
        ''' <param name="RFunction">CallBack function on value change</param>
        Public Sub New(ByVal InitValue As Object, ByVal T As Type, ByRef RFunction As IPropertyValue.ValueChangedEventHandler)
            Me.New(InitValue, T)
            OnChangeFunction = RFunction
        End Sub
        Private _Value As Object
        Public Property Value As Object Implements IPropertyValue.Value
            Get
                Return _Value
            End Get
            Set(ByVal NewValue As Object)
                _Value = NewValue
                If Not OnChangeFunction Is Nothing Then OnChangeFunction.Invoke(Value)
                RaiseEvent ValueChanged(_Value)
            End Set
        End Property
    End Class
    Public Interface IPropertyValue
        ''' <summary>Event for internal exchange</summary>
        ''' <param name="Value">New value</param>
        Event ValueChanged(ByVal Value As Object)
        ''' <summary>Value type</summary>
        Property [Type] As Type
        ''' <summary>Property value</summary>
        Property Value As Object
    End Interface
End Namespace