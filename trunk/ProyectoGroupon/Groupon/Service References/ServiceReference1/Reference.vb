﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
'
Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IServiceGroupon")>  _
    Public Interface IServiceGroupon
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IServiceGroupon/RegistraCliente", ReplyAction:="http://tempuri.org/IServiceGroupon/RegistraClienteResponse")>  _
        Function BeginRegistraCliente(ByVal oCliente As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndRegistraCliente(ByVal result As System.IAsyncResult) As Integer
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IServiceGrouponChannel
        Inherits ServiceReference1.IServiceGroupon, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class RegistraClienteCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As Integer
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceGrouponClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IServiceGroupon)
        Implements ServiceReference1.IServiceGroupon
        
        Private onBeginRegistraClienteDelegate As BeginOperationDelegate
        
        Private onEndRegistraClienteDelegate As EndOperationDelegate
        
        Private onRegistraClienteCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Property CookieContainer() As System.Net.CookieContainer
            Get
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    Return httpCookieContainerManager.CookieContainer
                Else
                    Return Nothing
                End If
            End Get
            Set
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    httpCookieContainerManager.CookieContainer = value
                Else
                    Throw New System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC"& _ 
                            "ookieContainerBindingElement.")
                End If
            End Set
        End Property
        
        Public Event RegistraClienteCompleted As System.EventHandler(Of RegistraClienteCompletedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_IServiceGroupon_BeginRegistraCliente(ByVal oCliente As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IServiceGroupon.BeginRegistraCliente
            Return MyBase.Channel.BeginRegistraCliente(oCliente, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_IServiceGroupon_EndRegistraCliente(ByVal result As System.IAsyncResult) As Integer Implements ServiceReference1.IServiceGroupon.EndRegistraCliente
            Return MyBase.Channel.EndRegistraCliente(result)
        End Function
        
        Private Function OnBeginRegistraCliente(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim oCliente As String = CType(inValues(0),String)
            Return CType(Me,ServiceReference1.IServiceGroupon).BeginRegistraCliente(oCliente, callback, asyncState)
        End Function
        
        Private Function OnEndRegistraCliente(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As Integer = CType(Me,ServiceReference1.IServiceGroupon).EndRegistraCliente(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnRegistraClienteCompleted(ByVal state As Object)
            If (Not (Me.RegistraClienteCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent RegistraClienteCompleted(Me, New RegistraClienteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub RegistraClienteAsync(ByVal oCliente As String)
            Me.RegistraClienteAsync(oCliente, Nothing)
        End Sub
        
        Public Overloads Sub RegistraClienteAsync(ByVal oCliente As String, ByVal userState As Object)
            If (Me.onBeginRegistraClienteDelegate Is Nothing) Then
                Me.onBeginRegistraClienteDelegate = AddressOf Me.OnBeginRegistraCliente
            End If
            If (Me.onEndRegistraClienteDelegate Is Nothing) Then
                Me.onEndRegistraClienteDelegate = AddressOf Me.OnEndRegistraCliente
            End If
            If (Me.onRegistraClienteCompletedDelegate Is Nothing) Then
                Me.onRegistraClienteCompletedDelegate = AddressOf Me.OnRegistraClienteCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginRegistraClienteDelegate, New Object() {oCliente}, Me.onEndRegistraClienteDelegate, Me.onRegistraClienteCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(callback, asyncState)
        End Function
        
        Private Function OnEndOpen(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndOpen(result)
            Return Nothing
        End Function
        
        Private Sub OnOpenCompleted(ByVal state As Object)
            If (Not (Me.OpenCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent OpenCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub OpenAsync()
            Me.OpenAsync(Nothing)
        End Sub
        
        Public Overloads Sub OpenAsync(ByVal userState As Object)
            If (Me.onBeginOpenDelegate Is Nothing) Then
                Me.onBeginOpenDelegate = AddressOf Me.OnBeginOpen
            End If
            If (Me.onEndOpenDelegate Is Nothing) Then
                Me.onEndOpenDelegate = AddressOf Me.OnEndOpen
            End If
            If (Me.onOpenCompletedDelegate Is Nothing) Then
                Me.onOpenCompletedDelegate = AddressOf Me.OnOpenCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginOpenDelegate, Nothing, Me.onEndOpenDelegate, Me.onOpenCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginClose(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(callback, asyncState)
        End Function
        
        Private Function OnEndClose(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndClose(result)
            Return Nothing
        End Function
        
        Private Sub OnCloseCompleted(ByVal state As Object)
            If (Not (Me.CloseCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent CloseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub CloseAsync()
            Me.CloseAsync(Nothing)
        End Sub
        
        Public Overloads Sub CloseAsync(ByVal userState As Object)
            If (Me.onBeginCloseDelegate Is Nothing) Then
                Me.onBeginCloseDelegate = AddressOf Me.OnBeginClose
            End If
            If (Me.onEndCloseDelegate Is Nothing) Then
                Me.onEndCloseDelegate = AddressOf Me.OnEndClose
            End If
            If (Me.onCloseCompletedDelegate Is Nothing) Then
                Me.onCloseCompletedDelegate = AddressOf Me.OnCloseCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginCloseDelegate, Nothing, Me.onEndCloseDelegate, Me.onCloseCompletedDelegate, userState)
        End Sub
        
        Protected Overrides Function CreateChannel() As ServiceReference1.IServiceGroupon
            Return New ServiceGrouponClientChannel(Me)
        End Function
        
        Private Class ServiceGrouponClientChannel
            Inherits ChannelBase(Of ServiceReference1.IServiceGroupon)
            Implements ServiceReference1.IServiceGroupon
            
            Public Sub New(ByVal client As System.ServiceModel.ClientBase(Of ServiceReference1.IServiceGroupon))
                MyBase.New(client)
            End Sub
            
            Public Function BeginRegistraCliente(ByVal oCliente As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IServiceGroupon.BeginRegistraCliente
                Dim _args((1) - 1) As Object
                _args(0) = oCliente
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("RegistraCliente", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndRegistraCliente(ByVal result As System.IAsyncResult) As Integer Implements ServiceReference1.IServiceGroupon.EndRegistraCliente
                Dim _args((0) - 1) As Object
                Dim _result As Integer = CType(MyBase.EndInvoke("RegistraCliente", _args, result),Integer)
                Return _result
            End Function
        End Class
    End Class
End Namespace