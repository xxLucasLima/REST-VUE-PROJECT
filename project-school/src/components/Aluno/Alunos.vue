<template>
  <div>
<<<<<<< HEAD
    <Titulo texto="Alunos"/>
    <input type="text" placeholder="Nome do Aluno" v-model="nome" @keyup.enter="addAluno()">
    <button class="btn btnInput" @click="addAluno()">Adicionar</button>
        <table>
          <thead>
            <th>Matricula</th>
            <th>Nome</th>
            <th>Opções</th>
          </thead>
          <tbody v-if="alunos.length">
            <tr v-for="(aluno, index) in alunos" :key="index">
              <td>{{aluno.id}}</td>
              <!-- <td>{{aluno.id}}</td> -->
              <td>{{aluno.nome}}</td>
              <td>
                <button class="btn" @click="remover(aluno)">Remover</button>
              </td>
            </tr>
          </tbody>
          <tfoot v-else>
            <h3>Nenhum aluno adicionado</h3>
          </tfoot>
        </table>

=======
    <Titulo
      :texto="
        professorid != undefined
          ? 'Professor: ' + professor.nome
          : 'Todos os Alunos'
      "
    />
    <div v-if="professorid != undefined">
      <input
        type="text"
        placeholder="Nome do Aluno"
        v-model="nome"
        @keyup.enter="addAluno()"
      />
      <button class="btn btnInput" @click="addAluno()">Adicionar</button>
    </div>
    <table>
      <thead>
        <th>Matricula</th>
        <th>Nome</th>
        <th>Opções</th>
      </thead>
      <tbody v-if="alunos.length">
        <tr v-for="(aluno, index) in alunos" :key="index">
          <td>{{ aluno.id }}</td>
          <router-link :to="`/alunoDetalhe/${aluno.id}`" tag="td" style="cursor: pointer">
            <td>{{ aluno.nome }}  {{aluno.sobrenome}}</td>
          </router-link>
          <td>
            <button class="btn" @click="remover(aluno)">Remover</button>
          </td>
        </tr>
      </tbody>
      <tfoot v-else>
        <h3>Nenhum aluno adicionado</h3>
      </tfoot>
    </table>
>>>>>>> Alterações em aluno e professor
  </div>
</template>

<script>
import Titulo from '../_share/Titulo';
export default {
<<<<<<< HEAD
  components:{
    Titulo
  },
  data(){
    return{
      titulo: "Alunos",
      nome: "",
      alunos:[]
          }
  },
  created() {
    this.$http.get('http://localhost:3000/alunos')
    .then(res => res.json())
    .then(alunos => this.alunos = alunos);
  },
  props: {
  },
  methods: {
    addAluno() {
      let _aluno = {
        nome:this.nome,
        sobrenome: " "
      }
      this.$http.post('http://localhost:3000/alunos', _aluno)
        .then(res => res.json())
        .then(alunoRetornado => {
          this.alunos.push(alunoRetornado);
        })

    },
    remover(aluno){
      this.$http.delete(`http://localhost:3000/alunos/${aluno.id}`)
          .then(() => {
            let indice = this.alunos.indexOf(aluno);
            this.alunos.splice(indice, 1);
          });
    }
  },
}
=======
  components: {
    Titulo,
  },
  data() {
    return {
      titulo: 'Alunos',
      professorid: this.$route.params.prof_id,
      professor: {},
      nome: '',
      alunos: [],
    };
  },
  created() {
    if (this.professorid) {
      this.carregarProfessores();
      this.$http
        .get('http://localhost:3000/alunos?professor.id=' + this.professorid)
        .then(res => res.json())
        .then(alunos => (this.alunos = alunos));
    } else {
      this.$http
        .get('http://localhost:3000/alunos')
        .then(res => res.json())
        .then(alunos => (this.alunos = alunos));
    }
  },
  props: {},
  methods: {
    addAluno() {
      let _aluno = {
        nome: this.nome,
        sobrenome: ' ',
        professor: {
          id: this.professor.id,
          nome: this.professor.nome,
        },
      };
      this.$http
        .post('http://localhost:3000/alunos', _aluno)
        .then(res => res.json())
        .then(alunoRetornado => {
          this.alunos.push(alunoRetornado);
        });
    },
    remover(aluno) {
      this.$http.delete(`http://localhost:3000/alunos/${aluno.id}`).then(() => {
        let indice = this.alunos.indexOf(aluno);
        this.alunos.splice(indice, 1);
      });
    },
    carregarProfessores() {
      this.$http
        .get('http://localhost:3000/professores/' + this.professorid)
        .then(res => res.json())
        .then(professor => {
          this.professor = professor;
        });
    },
  },
};
>>>>>>> Alterações em aluno e professor
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
<<<<<<< HEAD

  input{
    border: 0;
    padding: 20px;
    font-size: 1.3em;
    color: #687f7f;
    display: inline;
  }
  .btnInput{
    border: 0;
    padding: 20px;
    font-size: 1.3em;
    display: inline;
    background-color: rgb(116, 115, 115);
  }

  .btnInput:active{
      margin-top: 0px;
      border-bottom: 0;
  }
=======
input {
  width: calc(100% - 192px);
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  color: #687f7f;
  display: inline;
}
.btnInput {
  width: 150px;
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  display: inline;
  background-color: rgb(116, 115, 115);
}

.btnInput:active {
  margin-top: 0px;
  border-bottom: 0;
}
>>>>>>> Alterações em aluno e professor
</style>
