using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RDI.NFe2.SchemaXML.GNRE
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TConfigUf
    {

        private TConfigUfAmbiente ambienteField;

        private TUf ufField;

        private TConfigUfSituacaoConsulta situacaoConsultaField;

        private TConfigUfExigeUfFavorecida exigeUfFavorecidaField;

        private TConfigUfExigeReceita exigeReceitaField;

        private TConfigUfReceita[] receitasField;

        /// <remarks/>
        public TConfigUfAmbiente ambiente
        {
            get
            {
                return this.ambienteField;
            }
            set
            {
                this.ambienteField = value;
            }
        }

        /// <remarks/>
        public TUf uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public TConfigUfSituacaoConsulta situacaoConsulta
        {
            get
            {
                return this.situacaoConsultaField;
            }
            set
            {
                this.situacaoConsultaField = value;
            }
        }

        /// <remarks/>
        // Aviso CODEGEN: Não há suporte para o atributo DefaultValue em membros do tipo TConfigUfExigeUfFavorecida nesta versão do .Net Framework.
        // Aviso CODEGEN: Só há suporte para o atributo 'default' em tipos primitivos. Ignorando atributo default='S'.
        public TConfigUfExigeUfFavorecida exigeUfFavorecida
        {
            get
            {
                return this.exigeUfFavorecidaField;
            }
            set
            {
                this.exigeUfFavorecidaField = value;
            }
        }

        /// <remarks/>
        // Aviso CODEGEN: Não há suporte para o atributo DefaultValue em membros do tipo TConfigUfExigeReceita nesta versão do .Net Framework.
        // Aviso CODEGEN: Só há suporte para o atributo 'default' em tipos primitivos. Ignorando atributo default='S'.
        public TConfigUfExigeReceita exigeReceita
        {
            get
            {
                return this.exigeReceitaField;
            }
            set
            {
                this.exigeReceitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("receita", IsNullable = false)]
        public TConfigUfReceita[] receitas
        {
            get
            {
                return this.receitasField;
            }
            set
            {
                this.receitasField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TConfigUfAmbiente
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TUf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfSituacaoConsulta
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfExigeUfFavorecida
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfExigeUfFavorecida()
        {
            this.campoField = TCamposGNRE.c01_UfFavorecida;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TCamposGNRE
    {

        /// <remarks/>
        c01_UfFavorecida,

        /// <remarks/>
        c02_receita,

        /// <remarks/>
        c25_detalhamentoReceita,

        /// <remarks/>
        c26_produto,

        /// <remarks/>
        c27_tipoIdentificacaoEmitente,

        /// <remarks/>
        c03_idContribuinteEmitente,

        /// <remarks/>
        c28_tipoDocOrigem,

        /// <remarks/>
        c04_docOrigem,

        /// <remarks/>
        c06_valorPrincipal,

        /// <remarks/>
        c07_atualizacaoMonetaria,

        /// <remarks/>
        c08_juros,

        /// <remarks/>
        c09_multa,

        /// <remarks/>
        c10_valorTotal,

        /// <remarks/>
        c14_dataVencimento,

        /// <remarks/>
        c33_dataPagamento,

        /// <remarks/>
        c29_dataLimitePagamento,

        /// <remarks/>
        c15_convenio,

        /// <remarks/>
        c16_razaoSocialEmitente,

        /// <remarks/>
        c17_inscricaoEstadualEmitente,

        /// <remarks/>
        c18_enderecoEmitente,

        /// <remarks/>
        c19_municipioEmitente,

        /// <remarks/>
        c20_ufEnderecoEmitente,

        /// <remarks/>
        c21_cepEmitente,

        /// <remarks/>
        c22_telefoneEmitente,

        /// <remarks/>
        c34_tipoIdentificacaoDestinatario,

        /// <remarks/>
        c35_idContribuinteDestinatario,

        /// <remarks/>
        c36_inscricaoEstadualDestinatario,

        /// <remarks/>
        c37_razaoSocialDestinatario,

        /// <remarks/>
        c38_municipioDestinatario,

        /// <remarks/>
        c30_nossoNumero,

        /// <remarks/>
        c05_referencia,

        /// <remarks/>
        periodo,

        /// <remarks/>
        mes,

        /// <remarks/>
        ano,

        /// <remarks/>
        parcela,

        /// <remarks/>
        c39_camposExtras,

        /// <remarks/>
        campoExtra,

        /// <remarks/>
        codigo,

        /// <remarks/>
        tipo,

        /// <remarks/>
        valor,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TSimNao
    {

        /// <remarks/>
        S,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfExigeReceita
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfExigeReceita()
        {
            this.campoField = TCamposGNRE.c02_receita;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceita
    {

        private TSimNao exigeContribuinteEmitenteField;

        private TConfigUfReceitaExigeDetalhamentoReceita exigeDetalhamentoReceitaField;

        private TConfigUfReceitaDetalhamentoReceita[] detalhamentosReceitaField;

        private TConfigUfReceitaExigeProduto exigeProdutoField;

        private TConfigUfReceitaProduto[] produtosField;

        private TConfigUfReceitaExigePeriodoReferencia exigePeriodoReferenciaField;

        private TConfigUfReceitaExigePeriodoApuracao exigePeriodoApuracaoField;

        private TConfigUfReceitaPeriodoApuracao[] periodosApuracaoField;

        private TConfigUfReceitaExigeParcela exigeParcelaField;

        private TConfigUfReceitaValorExigido valorExigidoField;

        private TConfigUfReceitaExigeDocumentoOrigem exigeDocumentoOrigemField;

        private TConfigUfReceitaTiposDocumentosOrigem tiposDocumentosOrigemField;

        private TSimNao exigeContribuinteDestinatarioField;

        private TConfigUfReceitaExigeDataVencimento exigeDataVencimentoField;

        private TConfigUfReceitaExigeDataPagamento exigeDataPagamentoField;

        private TConfigUfReceitaExigeConvenio exigeConvenioField;

        private TConfigUfReceitaExigeCamposAdicionais exigeCamposAdicionaisField;

        private TConfigUfReceitaCampoAdicional[] camposAdicionaisField;

        private string codigoField;

        private string descricaoField;

        private TSimNao courierField;

        public TConfigUfReceita()
        {
            this.exigeContribuinteEmitenteField = TSimNao.S;
            this.courierField = TSimNao.N;
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(TSimNao.S)]
        public TSimNao exigeContribuinteEmitente
        {
            get
            {
                return this.exigeContribuinteEmitenteField;
            }
            set
            {
                this.exigeContribuinteEmitenteField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigeDetalhamentoReceita exigeDetalhamentoReceita
        {
            get
            {
                return this.exigeDetalhamentoReceitaField;
            }
            set
            {
                this.exigeDetalhamentoReceitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detalhamentoReceita", IsNullable = false)]
        public TConfigUfReceitaDetalhamentoReceita[] detalhamentosReceita
        {
            get
            {
                return this.detalhamentosReceitaField;
            }
            set
            {
                this.detalhamentosReceitaField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigeProduto exigeProduto
        {
            get
            {
                return this.exigeProdutoField;
            }
            set
            {
                this.exigeProdutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("produto", IsNullable = false)]
        public TConfigUfReceitaProduto[] produtos
        {
            get
            {
                return this.produtosField;
            }
            set
            {
                this.produtosField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigePeriodoReferencia exigePeriodoReferencia
        {
            get
            {
                return this.exigePeriodoReferenciaField;
            }
            set
            {
                this.exigePeriodoReferenciaField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigePeriodoApuracao exigePeriodoApuracao
        {
            get
            {
                return this.exigePeriodoApuracaoField;
            }
            set
            {
                this.exigePeriodoApuracaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("periodoApuracao", IsNullable = false)]
        public TConfigUfReceitaPeriodoApuracao[] periodosApuracao
        {
            get
            {
                return this.periodosApuracaoField;
            }
            set
            {
                this.periodosApuracaoField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigeParcela exigeParcela
        {
            get
            {
                return this.exigeParcelaField;
            }
            set
            {
                this.exigeParcelaField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaValorExigido valorExigido
        {
            get
            {
                return this.valorExigidoField;
            }
            set
            {
                this.valorExigidoField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigeDocumentoOrigem exigeDocumentoOrigem
        {
            get
            {
                return this.exigeDocumentoOrigemField;
            }
            set
            {
                this.exigeDocumentoOrigemField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaTiposDocumentosOrigem tiposDocumentosOrigem
        {
            get
            {
                return this.tiposDocumentosOrigemField;
            }
            set
            {
                this.tiposDocumentosOrigemField = value;
            }
        }

        /// <remarks/>
        public TSimNao exigeContribuinteDestinatario
        {
            get
            {
                return this.exigeContribuinteDestinatarioField;
            }
            set
            {
                this.exigeContribuinteDestinatarioField = value;
            }
        }

        /// <remarks/>
        // Aviso CODEGEN: Não há suporte para o atributo DefaultValue em membros do tipo TConfigUfReceitaExigeDataVencimento nesta versão do .Net Framework.
        // Aviso CODEGEN: Só há suporte para o atributo 'default' em tipos primitivos. Ignorando atributo default='S'.
        public TConfigUfReceitaExigeDataVencimento exigeDataVencimento
        {
            get
            {
                return this.exigeDataVencimentoField;
            }
            set
            {
                this.exigeDataVencimentoField = value;
            }
        }

        /// <remarks/>
        // Aviso CODEGEN: Não há suporte para o atributo DefaultValue em membros do tipo TConfigUfReceitaExigeDataPagamento nesta versão do .Net Framework.
        // Aviso CODEGEN: Só há suporte para o atributo 'default' em tipos primitivos. Ignorando atributo default='S'.
        public TConfigUfReceitaExigeDataPagamento exigeDataPagamento
        {
            get
            {
                return this.exigeDataPagamentoField;
            }
            set
            {
                this.exigeDataPagamentoField = value;
            }
        }

        /// <remarks/>
        // Aviso CODEGEN: Não há suporte para o atributo DefaultValue em membros do tipo TConfigUfReceitaExigeConvenio nesta versão do .Net Framework.
        // Aviso CODEGEN: Só há suporte para o atributo 'default' em tipos primitivos. Ignorando atributo default='N'.
        public TConfigUfReceitaExigeConvenio exigeConvenio
        {
            get
            {
                return this.exigeConvenioField;
            }
            set
            {
                this.exigeConvenioField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaExigeCamposAdicionais exigeCamposAdicionais
        {
            get
            {
                return this.exigeCamposAdicionaisField;
            }
            set
            {
                this.exigeCamposAdicionaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("campoAdicional", IsNullable = false)]
        public TConfigUfReceitaCampoAdicional[] camposAdicionais
        {
            get
            {
                return this.camposAdicionaisField;
            }
            set
            {
                this.camposAdicionaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(TSimNao.N)]
        public TSimNao courier
        {
            get
            {
                return this.courierField;
            }
            set
            {
                this.courierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeDetalhamentoReceita
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeDetalhamentoReceita()
        {
            this.campoField = TCamposGNRE.c25_detalhamentoReceita;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaDetalhamentoReceita
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeProduto
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeProduto()
        {
            this.campoField = TCamposGNRE.c26_produto;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaProduto
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigePeriodoReferencia
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigePeriodoReferencia()
        {
            this.campoField = TCamposGNRE.c05_referencia;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigePeriodoApuracao
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigePeriodoApuracao()
        {
            this.campoField = TCamposGNRE.periodo;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaPeriodoApuracao
    {

        private TConfigUfReceitaPeriodoApuracaoCodigo codigoField;

        private string descricaoField;

        /// <remarks/>
        public TConfigUfReceitaPeriodoApuracaoCodigo codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TConfigUfReceitaPeriodoApuracaoCodigo
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeParcela
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeParcela()
        {
            this.campoField = TCamposGNRE.parcela;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaValorExigido
    {

        private TCamposGNRE campoField;

        private bool campoFieldSpecified;

        private TTipoValor valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool campoSpecified
        {
            get
            {
                return this.campoFieldSpecified;
            }
            set
            {
                this.campoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TTipoValor Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TTipoValor
    {

        /// <remarks/>
        P,

        /// <remarks/>
        T,

        /// <remarks/>
        A,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeDocumentoOrigem
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeDocumentoOrigem()
        {
            this.campoField = TCamposGNRE.c04_docOrigem;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaTiposDocumentosOrigem
    {

        private TConfigUfReceitaTiposDocumentosOrigemTipoDocumentoOrigem[] tipoDocumentoOrigemField;

        private TCamposGNRE campoField;

        public TConfigUfReceitaTiposDocumentosOrigem()
        {
            this.campoField = TCamposGNRE.c28_tipoDocOrigem;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipoDocumentoOrigem")]
        public TConfigUfReceitaTiposDocumentosOrigemTipoDocumentoOrigem[] tipoDocumentoOrigem
        {
            get
            {
                return this.tipoDocumentoOrigemField;
            }
            set
            {
                this.tipoDocumentoOrigemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaTiposDocumentosOrigemTipoDocumentoOrigem
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeDataVencimento
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeDataVencimento()
        {
            this.campoField = TCamposGNRE.c14_dataVencimento;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeDataPagamento
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeDataPagamento()
        {
            this.campoField = TCamposGNRE.c33_dataPagamento;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeConvenio
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeConvenio()
        {
            this.campoField = TCamposGNRE.c15_convenio;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaExigeCamposAdicionais
    {

        private TCamposGNRE campoField;

        private TSimNao valueField;

        public TConfigUfReceitaExigeCamposAdicionais()
        {
            this.campoField = TCamposGNRE.c39_camposExtras;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TSimNao Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaCampoAdicional
    {

        private TSimNao obrigatorioField;

        private TConfigUfReceitaCampoAdicionalCodigo codigoField;

        private TConfigUfReceitaCampoAdicionalTipo tipoField;

        private int tamanhoField;

        private bool tamanhoFieldSpecified;

        private int casasDecimaisField;

        private bool casasDecimaisFieldSpecified;

        private string tituloField;

        private TCamposGNRE campoField;

        public TConfigUfReceitaCampoAdicional()
        {
            this.campoField = TCamposGNRE.campoExtra;
        }

        /// <remarks/>
        public TSimNao obrigatorio
        {
            get
            {
                return this.obrigatorioField;
            }
            set
            {
                this.obrigatorioField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaCampoAdicionalCodigo codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public TConfigUfReceitaCampoAdicionalTipo tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        public int tamanho
        {
            get
            {
                return this.tamanhoField;
            }
            set
            {
                this.tamanhoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tamanhoSpecified
        {
            get
            {
                return this.tamanhoFieldSpecified;
            }
            set
            {
                this.tamanhoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int casasDecimais
        {
            get
            {
                return this.casasDecimaisField;
            }
            set
            {
                this.casasDecimaisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool casasDecimaisSpecified
        {
            get
            {
                return this.casasDecimaisFieldSpecified;
            }
            set
            {
                this.casasDecimaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string titulo
        {
            get
            {
                return this.tituloField;
            }
            set
            {
                this.tituloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaCampoAdicionalCodigo
    {

        private TCamposGNRE campoField;

        private bool campoFieldSpecified;

        private int valueField;

        public TConfigUfReceitaCampoAdicionalCodigo()
        {
            this.campoField = TCamposGNRE.codigo;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool campoSpecified
        {
            get
            {
                return this.campoFieldSpecified;
            }
            set
            {
                this.campoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public int Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConfigUfReceitaCampoAdicionalTipo
    {

        private TCamposGNRE campoField;

        private bool campoFieldSpecified;

        private TTipoCampoExtra valueField;

        public TConfigUfReceitaCampoAdicionalTipo()
        {
            this.campoField = TCamposGNRE.tipo;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TCamposGNRE campo
        {
            get
            {
                return this.campoField;
            }
            set
            {
                this.campoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool campoSpecified
        {
            get
            {
                return this.campoFieldSpecified;
            }
            set
            {
                this.campoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public TTipoCampoExtra Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TTipoCampoExtra
    {

        /// <remarks/>
        T,

        /// <remarks/>
        N,

        /// <remarks/>
        D,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TConsultaConfigUf
    {

        private TConsultaConfigUfAmbiente ambienteField;

        private TUf ufField;

        private TConsultaConfigUfReceita receitaField;

        /// <remarks/>
        public TConsultaConfigUfAmbiente ambiente
        {
            get
            {
                return this.ambienteField;
            }
            set
            {
                this.ambienteField = value;
            }
        }

        /// <remarks/>
        public TUf uf
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        /// <remarks/>
        public TConsultaConfigUfReceita receita
        {
            get
            {
                return this.receitaField;
            }
            set
            {
                this.receitaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TConsultaConfigUfAmbiente
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TConsultaConfigUfReceita
    {

        private TSimNao courierField;

        private bool courierFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TSimNao courier
        {
            get
            {
                return this.courierField;
            }
            set
            {
                this.courierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool courierSpecified
        {
            get
            {
                return this.courierFieldSpecified;
            }
            set
            {
                this.courierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TConsLote_GNRE
    {

        private TConsLote_GNREAmbiente ambienteField;

        private string numeroReciboField;

        /// <remarks/>
        public TConsLote_GNREAmbiente ambiente
        {
            get
            {
                return this.ambienteField;
            }
            set
            {
                this.ambienteField = value;
            }
        }

        /// <remarks/>
        public string numeroRecibo
        {
            get
            {
                return this.numeroReciboField;
            }
            set
            {
                this.numeroReciboField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TConsLote_GNREAmbiente
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TRetLote_GNRE
    {

        private TRetLote_GNREAmbiente ambienteField;

        private TRetLote_GNRESituacaoRecepcao situacaoRecepcaoField;

        private TRetLote_GNRERecibo reciboField;

        /// <remarks/>
        public TRetLote_GNREAmbiente ambiente
        {
            get
            {
                return this.ambienteField;
            }
            set
            {
                this.ambienteField = value;
            }
        }

        /// <remarks/>
        public TRetLote_GNRESituacaoRecepcao situacaoRecepcao
        {
            get
            {
                return this.situacaoRecepcaoField;
            }
            set
            {
                this.situacaoRecepcaoField = value;
            }
        }

        /// <remarks/>
        public TRetLote_GNRERecibo recibo
        {
            get
            {
                return this.reciboField;
            }
            set
            {
                this.reciboField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TRetLote_GNREAmbiente
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TRetLote_GNRESituacaoRecepcao
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TRetLote_GNRERecibo
    {

        private string numeroField;

        private string dataHoraReciboField;

        private int tempoEstimadoProcField;

        /// <remarks/>
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }

        /// <remarks/>
        public string dataHoraRecibo
        {
            get
            {
                return this.dataHoraReciboField;
            }
            set
            {
                this.dataHoraReciboField = value;
            }
        }

        /// <remarks/>
        public int tempoEstimadoProc
        {
            get
            {
                return this.tempoEstimadoProcField;
            }
            set
            {
                this.tempoEstimadoProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TResultLote_GNRE
    {

        private TResultLote_GNREAmbiente ambienteField;

        private string numeroReciboField;

        private TResultLote_GNRESituacaoProcess situacaoProcessField;

        private string resultadoField;

        /// <remarks/>
        public TResultLote_GNREAmbiente ambiente
        {
            get
            {
                return this.ambienteField;
            }
            set
            {
                this.ambienteField = value;
            }
        }

        /// <remarks/>
        public string numeroRecibo
        {
            get
            {
                return this.numeroReciboField;
            }
            set
            {
                this.numeroReciboField = value;
            }
        }

        /// <remarks/>
        public TResultLote_GNRESituacaoProcess situacaoProcess
        {
            get
            {
                return this.situacaoProcessField;
            }
            set
            {
                this.situacaoProcessField = value;
            }
        }

        /// <remarks/>
        public string resultado
        {
            get
            {
                return this.resultadoField;
            }
            set
            {
                this.resultadoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TResultLote_GNREAmbiente
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TResultLote_GNRESituacaoProcess
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br", IsNullable = false)]
    public partial class TLote_GNRE
    {

        private TLote_GNRETDadosGNRE[] guiasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TDadosGNRE", IsNullable = false)]
        public TLote_GNRETDadosGNRE[] guias
        {
            get
            {
                return this.guiasField;
            }
            set
            {
                this.guiasField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TLote_GNRETDadosGNRE
    {

        private TUf c01_UfFavorecidaField;

        private string c02_receitaField;

        private string c25_detalhamentoReceitaField;

        private string c26_produtoField;

        private TIdentificacao c27_tipoIdentificacaoEmitenteField;

        private bool c27_tipoIdentificacaoEmitenteFieldSpecified;

        private TLote_GNRETDadosGNREC03_idContribuinteEmitente c03_idContribuinteEmitenteField;

        private string c28_tipoDocOrigemField;

        private string c04_docOrigemField;

        private string c06_valorPrincipalField;

        private string c10_valorTotalField;

        private string c14_dataVencimentoField;

        private string c15_convenioField;

        private string c16_razaoSocialEmitenteField;

        private string c17_inscricaoEstadualEmitenteField;

        private string c18_enderecoEmitenteField;

        private string c19_municipioEmitenteField;

        private TUf c20_ufEnderecoEmitenteField;

        private bool c20_ufEnderecoEmitenteFieldSpecified;

        private string c21_cepEmitenteField;

        private string c22_telefoneEmitenteField;

        private TIdentificacao c34_tipoIdentificacaoDestinatarioField;

        private bool c34_tipoIdentificacaoDestinatarioFieldSpecified;

        private TLote_GNRETDadosGNREC35_idContribuinteDestinatario c35_idContribuinteDestinatarioField;

        private string c36_inscricaoEstadualDestinatarioField;

        private string c37_razaoSocialDestinatarioField;

        private string c38_municipioDestinatarioField;

        private string c33_dataPagamentoField;

        private TLote_GNRETDadosGNREC05_referencia c05_referenciaField;

        private TLote_GNRETDadosGNRECampoExtra[] c39_camposExtrasField;

        private string c42_identificadorGuiaField;

        /// <remarks/>
        public TUf c01_UfFavorecida
        {
            get
            {
                return this.c01_UfFavorecidaField;
            }
            set
            {
                this.c01_UfFavorecidaField = value;
            }
        }

        /// <remarks/>
        public string c02_receita
        {
            get
            {
                return this.c02_receitaField;
            }
            set
            {
                this.c02_receitaField = value;
            }
        }

        /// <remarks/>
        public string c25_detalhamentoReceita
        {
            get
            {
                return this.c25_detalhamentoReceitaField;
            }
            set
            {
                this.c25_detalhamentoReceitaField = value;
            }
        }

        /// <remarks/>
        public string c26_produto
        {
            get
            {
                return this.c26_produtoField;
            }
            set
            {
                this.c26_produtoField = value;
            }
        }

        /// <remarks/>
        public TIdentificacao c27_tipoIdentificacaoEmitente
        {
            get
            {
                return this.c27_tipoIdentificacaoEmitenteField;
            }
            set
            {
                this.c27_tipoIdentificacaoEmitenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool c27_tipoIdentificacaoEmitenteSpecified
        {
            get
            {
                return this.c27_tipoIdentificacaoEmitenteFieldSpecified;
            }
            set
            {
                this.c27_tipoIdentificacaoEmitenteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TLote_GNRETDadosGNREC03_idContribuinteEmitente c03_idContribuinteEmitente
        {
            get
            {
                return this.c03_idContribuinteEmitenteField;
            }
            set
            {
                this.c03_idContribuinteEmitenteField = value;
            }
        }

        /// <remarks/>
        public string c28_tipoDocOrigem
        {
            get
            {
                return this.c28_tipoDocOrigemField;
            }
            set
            {
                this.c28_tipoDocOrigemField = value;
            }
        }

        /// <remarks/>
        public string c04_docOrigem
        {
            get
            {
                return this.c04_docOrigemField;
            }
            set
            {
                this.c04_docOrigemField = value;
            }
        }

        /// <remarks/>
        public string c06_valorPrincipal
        {
            get
            {
                return this.c06_valorPrincipalField;
            }
            set
            {
                this.c06_valorPrincipalField = value;
            }
        }

        /// <remarks/>
        public string c10_valorTotal
        {
            get
            {
                return this.c10_valorTotalField;
            }
            set
            {
                this.c10_valorTotalField = value;
            }
        }

        /// <remarks/>
        public string c14_dataVencimento
        {
            get
            {
                return this.c14_dataVencimentoField;
            }
            set
            {
                this.c14_dataVencimentoField = value;
            }
        }

        /// <remarks/>
        public string c15_convenio
        {
            get
            {
                return this.c15_convenioField;
            }
            set
            {
                this.c15_convenioField = value;
            }
        }

        /// <remarks/>
        public string c16_razaoSocialEmitente
        {
            get
            {
                return this.c16_razaoSocialEmitenteField;
            }
            set
            {
                this.c16_razaoSocialEmitenteField = value;
            }
        }

        /// <remarks/>
        public string c17_inscricaoEstadualEmitente
        {
            get
            {
                return this.c17_inscricaoEstadualEmitenteField;
            }
            set
            {
                this.c17_inscricaoEstadualEmitenteField = value;
            }
        }

        /// <remarks/>
        public string c18_enderecoEmitente
        {
            get
            {
                return this.c18_enderecoEmitenteField;
            }
            set
            {
                this.c18_enderecoEmitenteField = value;
            }
        }

        /// <remarks/>
        public string c19_municipioEmitente
        {
            get
            {
                return this.c19_municipioEmitenteField;
            }
            set
            {
                this.c19_municipioEmitenteField = value;
            }
        }

        /// <remarks/>
        public TUf c20_ufEnderecoEmitente
        {
            get
            {
                return this.c20_ufEnderecoEmitenteField;
            }
            set
            {
                this.c20_ufEnderecoEmitenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool c20_ufEnderecoEmitenteSpecified
        {
            get
            {
                return this.c20_ufEnderecoEmitenteFieldSpecified;
            }
            set
            {
                this.c20_ufEnderecoEmitenteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string c21_cepEmitente
        {
            get
            {
                return this.c21_cepEmitenteField;
            }
            set
            {
                this.c21_cepEmitenteField = value;
            }
        }

        /// <remarks/>
        public string c22_telefoneEmitente
        {
            get
            {
                return this.c22_telefoneEmitenteField;
            }
            set
            {
                this.c22_telefoneEmitenteField = value;
            }
        }

        /// <remarks/>
        public TIdentificacao c34_tipoIdentificacaoDestinatario
        {
            get
            {
                return this.c34_tipoIdentificacaoDestinatarioField;
            }
            set
            {
                this.c34_tipoIdentificacaoDestinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool c34_tipoIdentificacaoDestinatarioSpecified
        {
            get
            {
                return this.c34_tipoIdentificacaoDestinatarioFieldSpecified;
            }
            set
            {
                this.c34_tipoIdentificacaoDestinatarioFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TLote_GNRETDadosGNREC35_idContribuinteDestinatario c35_idContribuinteDestinatario
        {
            get
            {
                return this.c35_idContribuinteDestinatarioField;
            }
            set
            {
                this.c35_idContribuinteDestinatarioField = value;
            }
        }

        /// <remarks/>
        public string c36_inscricaoEstadualDestinatario
        {
            get
            {
                return this.c36_inscricaoEstadualDestinatarioField;
            }
            set
            {
                this.c36_inscricaoEstadualDestinatarioField = value;
            }
        }

        /// <remarks/>
        public string c37_razaoSocialDestinatario
        {
            get
            {
                return this.c37_razaoSocialDestinatarioField;
            }
            set
            {
                this.c37_razaoSocialDestinatarioField = value;
            }
        }

        /// <remarks/>
        public string c38_municipioDestinatario
        {
            get
            {
                return this.c38_municipioDestinatarioField;
            }
            set
            {
                this.c38_municipioDestinatarioField = value;
            }
        }

        /// <remarks/>
        public string c33_dataPagamento
        {
            get
            {
                return this.c33_dataPagamentoField;
            }
            set
            {
                this.c33_dataPagamentoField = value;
            }
        }

        /// <remarks/>
        public TLote_GNRETDadosGNREC05_referencia c05_referencia
        {
            get
            {
                return this.c05_referenciaField;
            }
            set
            {
                this.c05_referenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("campoExtra", IsNullable = false)]
        public TLote_GNRETDadosGNRECampoExtra[] c39_camposExtras
        {
            get
            {
                return this.c39_camposExtrasField;
            }
            set
            {
                this.c39_camposExtrasField = value;
            }
        }

        /// <remarks/>
        public string c42_identificadorGuia
        {
            get
            {
                return this.c42_identificadorGuiaField;
            }
            set
            {
                this.c42_identificadorGuiaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TIdentificacao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TLote_GNRETDadosGNREC03_idContribuinteEmitente
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TLote_GNRETDadosGNREC35_idContribuinteDestinatario
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TLote_GNRETDadosGNREC05_referencia
    {

        private TLote_GNRETDadosGNREC05_referenciaPeriodo periodoField;

        private bool periodoFieldSpecified;

        private TMes mesField;

        private bool mesFieldSpecified;

        private string anoField;

        private string parcelaField;

        /// <remarks/>
        public TLote_GNRETDadosGNREC05_referenciaPeriodo periodo
        {
            get
            {
                return this.periodoField;
            }
            set
            {
                this.periodoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodoSpecified
        {
            get
            {
                return this.periodoFieldSpecified;
            }
            set
            {
                this.periodoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TMes mes
        {
            get
            {
                return this.mesField;
            }
            set
            {
                this.mesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mesSpecified
        {
            get
            {
                return this.mesFieldSpecified;
            }
            set
            {
                this.mesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ano
        {
            get
            {
                return this.anoField;
            }
            set
            {
                this.anoField = value;
            }
        }

        /// <remarks/>
        public string parcela
        {
            get
            {
                return this.parcelaField;
            }
            set
            {
                this.parcelaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public enum TLote_GNRETDadosGNREC05_referenciaPeriodo
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gnre.pe.gov.br")]
    public enum TMes
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br")]
    public partial class TLote_GNRETDadosGNRECampoExtra
    {

        private int codigoField;

        private TTipoCampoExtra tipoField;

        private string valorField;

        /// <remarks/>
        public int codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public TTipoCampoExtra tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        public string valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }
    }
}
