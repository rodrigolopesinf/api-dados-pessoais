using Agora.Brokerage.Alteracao.DadosPessoais.Core.DTO;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Command;
using Agora.Brokerage.Bill.Api.Controllers;
using Agora.Brokerage.Bill.Core.Validantions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Agora.Brokerage.Alteracao.DadosPessoais.API.Controllers
{
    [Produces("application/json")]
    [Route("api/atualizacao")]
    public class AtualizacaoController : BaseController
    {
        private readonly IAtualizarDadosPessoaisCommand _command;

        public AtualizacaoController(IAtualizarDadosPessoaisCommand command, INotification notification) : base(notification)
        {
            _command = command;
        }

        /// <summary>
        /// Realiza a Alteração dos Dados de Acesso
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("dadosPessoais")]
        public async Task<IActionResult> Atualizar([FromBody] DadosPessoaisDto request)
        {
            var response = await _command.Executar(request.ToRequest());

            if(response)
                return NoContent();
            else
                return StatusCode(400, ObterErro());
        }  
    }
}