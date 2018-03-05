using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjeto.DataProvider.Models;
using WebProjeto.DataProvider.Repository;

namespace WebProjeto.DataProvider.Service
{
    public class LivroService
    {
        private LivroRepository livroRepository;

        private List<string> mensagens;

        //private System.Web.ModelBinding.ModelStateDictionary modelState;

        public LivroService()
        {
            livroRepository = new LivroRepository();
        }

        public IEnumerable<LivroModel> ListaLivro()
        {
            return livroRepository.Localizar();
        }

        public LivroModel ListarPorId(LivroModel model)
        {
            return livroRepository.LocalizarPorId(model);
        }

        public string Salvar(LivroModel model)
        {
            if (!ValidaLivro(model))
            {
                return "AVISO";
            }

            bool salvou = false;
            try
            {
                if (model.Id == 0)
                {
                    salvou = livroRepository.Salvar(model);
                }
                else
                {
                    salvou = livroRepository.Atualizar(model);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return "OK";
        }

        public string Remover(LivroModel model)
        {
            bool excluiu = false;
            try
            {
                excluiu = livroRepository.Remover(model);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return "OK";
        }

        public bool ValidaLivro(LivroModel model) {

            if (string.IsNullOrEmpty(model.Nome)) {
                return false;
            }

            if (string.IsNullOrEmpty(model.Autor))
            {
                return false;
            }

            if (string.IsNullOrEmpty(model.Editora))
            {
                return false;
            }

            return true;
        }

    }
}
