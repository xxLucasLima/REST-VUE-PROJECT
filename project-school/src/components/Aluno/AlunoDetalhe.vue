<template>
  <div>
    <titulo :texto="`Aluno: ${aluno.nome}`" :btnVoltar="true">
      <button class="btn btnEditar">Editar</button>
    </titulo>
    <table>
      <tbody>
        <tr>
          <td class="colPequeno">Matrícula:</td>
          <td>
            <label>{{ aluno.id }}</label>
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Nome:</td>
          <td>
            <label>{{ aluno.nome }}</label>
            <input v-model="aluno.nome" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Sobrenome:</td>
          <td>
            <label>{{ aluno.sobrenome }}</label>
            <input v-model="aluno.sobrenome" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Data de nascimento</td>
          <td>
            <label>{{ aluno.dataNasc }}</label>
            <input v-model="aluno.dataNasc" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Professor:</td>
          <td>
            <label>{{ aluno.professor.nome }}</label>
            <select v-model="aluno.professor">
              <option
                v-for="(professor, index) in professores"
                :key="index"
                v-bind:value="professor"
              >
                {{ professor.nome }}
              </option>
            </select>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import Titulo from '../_share/Titulo';

export default {
  components: {
    Titulo,
  },
  data() {
    return {
      professores: [],
      aluno: {},
      idAluno: this.$route.params.id,
    };
  },
  created() {
    this.$http
      .get('http://localhost:3000/alunos/' + this.idAluno)
      .then(res => res.json())
      .then(aluno => (this.aluno = aluno));

    this.$http
      .get('http://localhost:3000/professores/')
      .then(res => res.json())
      .then(professores => {
        this.professores = professores;
      });
  },
  methods: {},
};
</script>

<style lang="scss" scoped>
.colPequeno {
  width: 20%;
  text-align: right;
  background-color: rgb(125, 217, 245);
  font-weight: bold;
}
input,
select {
  margin: 0px;
  padding: 5px 10px;
  font-size: 0.9em;
  border-radius: 5px;
  border: 1px solid silver;
  width: 95%;
  background-color: rgb(245, 245, 245);
}
select {
  height: 38px;
  width: 100%;
}
.btnEditar {
  float: right;
  background-color: rgb(76, 186, 249);
}
</style>
