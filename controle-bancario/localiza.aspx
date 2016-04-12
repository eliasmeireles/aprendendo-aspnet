<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="localiza.aspx.cs" Inherits="controle_bancario.localiza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%		   
        Response.WriteFile("head.html");
    %>
</head>
<body>
    <%		   
        Response.WriteFile("menu.html");
    %>
        
    <h2 class="cadastro-title font-primary-bold">Dados do Clientee</h2>
        
    <form id="form1" runat="server" class="formulario">


        <div class="form-container">
            <div class="cliente-dados">
                <asp:Label ID="Label3" runat="server" Text="Dados Pessoais" CssClass="cliente-sub-title font-primary-bold"></asp:Label>

                <asp:TextBox ID="nome" runat="server" placeholder="Nome" CssClass="input-form font-primary"></asp:TextBox>
                <asp:Label ID="nomeErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>

                <asp:TextBox ID="sobreNome" runat="server" placeholder="Sobrenome" CssClass="input-form font-primary"></asp:TextBox>
                <asp:Label ID="sobrenomeErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>

                <asp:TextBox ID="email" type="email" runat="server" placeholder="Email" CssClass="input-form font-primary"></asp:TextBox>
                <asp:Label ID="emailErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="cpf" runat="server" placeholder="CPF" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="cpfErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="dataNascimento" runat="server" placeholder="Data de Nascimento" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="nascimentoErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="telefone" runat="server" placeholder="Telefone" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="telefoneErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="celular" runat="server" placeholder="Celular" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="celularErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                </div>


            </div>

            <div class="cliente-dados">

                <asp:Label ID="Label2" runat="server" Text="Endereço" CssClass="cliente-sub-title font-primary-bold"></asp:Label>

                <asp:TextBox ID="cep" runat="server" placeholder="CEP" CssClass="input-form font-primary"></asp:TextBox>
                <asp:Label ID="cepErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>

                <asp:TextBox ID="logradouro" runat="server" placeholder="Logradouro" CssClass="input-form font-primary"></asp:TextBox>
                <asp:Label ID="logradouroErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="numero" runat="server" placeholder="Número" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="numeroErro" runat="server" Text="" CssClass="input-form error error font-primary"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="complemento" runat="server" placeholder="Complemento" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="complementoErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="bairro" runat="server" placeholder="Bairro" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="bairroErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="cidade" runat="server" placeholder="Cidade" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="cidadeErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="estado" runat="server" placeholder="Estado" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="estadoErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="pais" runat="server" placeholder="Pais" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="paisErro" runat="server" Text="" CssClass="input-form error font-primary"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <asp:button ID="localizar" runat="server" text="Localizar" CssClass="btn btn-cadastrar font-primary-bold_mediun" OnClick="cadastrar_Click" />
    </form>
    <%		   
        Response.WriteFile("footer.html");
    %>
</body>
</html>
