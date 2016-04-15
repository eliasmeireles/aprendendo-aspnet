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
            <div class="cliente-dados form-localiza">
                <asp:Label ID="Label3" runat="server" Text="Dados Pessoais" CssClass="cliente-sub-title font-primary-bold"></asp:Label>

                <asp:TextBox ID="nome" runat="server" placeholder="Nome" disabled CssClass="input-form font-primary"></asp:TextBox>

                <asp:TextBox ID="sobreNome" runat="server" placeholder="Sobrenome" disabled CssClass="input-form font-primary"></asp:TextBox>

                <asp:TextBox ID="email" type="email" runat="server" placeholder="Email" disabled CssClass="input-form font-primary"></asp:TextBox>

                <div class="litle-input cpf-form">
                    <div class="divisor">
                        <asp:TextBox ID="cpf" runat="server" placeholder="CPF" CssClass="input-form font-primary"></asp:TextBox>
                        <asp:Label ID="cpfErro" runat="server" Text="" CssClass="cliente-sub-title error font-primary-bold"></asp:Label>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="dataNascimento" runat="server" disabled placeholder="Data de Nascimento" CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="telefone" runat="server" placeholder="Telefone" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="celular" runat="server" placeholder="Celular" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                </div>


            </div>

            <div class="cliente-dados form-localiza">

                <asp:Label ID="Label2" runat="server" Text="Endereço" CssClass="cliente-sub-title font-primary-bold"></asp:Label>

                <asp:TextBox ID="cep" runat="server" placeholder="CEP" disabled CssClass="input-form font-primary"></asp:TextBox>

                <asp:TextBox ID="logradouro" runat="server" placeholder="Logradouro" disabled CssClass="input-form font-primary"></asp:TextBox>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="numero" runat="server" placeholder="Número" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="complemento" runat="server" placeholder="Complemento" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="bairro" runat="server" placeholder="Bairro"  disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="cidade" runat="server" placeholder="Cidade" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                </div>

                <div class="litle-input">
                    <div class="divisor">
                        <asp:TextBox ID="estado" runat="server" placeholder="Estado" disabled CssClass="input-form font-primary"></asp:TextBox>
                    </div>
                    <div class="divisor">
                        <asp:TextBox ID="pais" runat="server" placeholder="Pais" disabled CssClass="input-form font-primary"></asp:TextBox>
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
