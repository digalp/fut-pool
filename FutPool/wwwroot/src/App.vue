<template>
    <div id="app">
        <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
            <a class="navbar-brand" href="#">FutPool</a>
            <div id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Features</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Pricing</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link disabled" href="#">Disabled</a>
                    </li>
                </ul>
            </div>
        </nav>
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div>
                    <form>
                        <div class="form-row">
                            <div class="form-group">
                                <label for="homeName1" class="sr-only">Email</label>
                                <input type="text" readonly class="form-control-plaintext text-right" id="homeName1" value="Barcelona">
                            </div>
                            <div class="form-group btn-group-toggle">
                                <label class="btn btn-secondary px-5 ml-2" :class="{ 'active focus': selectedResult === 'Home' }">
                                    <input type="radio" name="result" value="Home" id="option1" autocomplete="off"
                                        v-model="selectedResult"
                                        @click="handleClickOnResultOption"> Home
                                </label>
                                <label class="btn btn-secondary px-5" :class="{'active focus': selectedResult === 'Tie' }">
                                    <input type="radio" name="result" value="Tie" id="option2" autocomplete="off"
                                        v-model="selectedResult"
                                        @click="handleClickOnResultOption"> Tie
                                </label>
                                <label class="btn btn-secondary px-5" :class="{ 'active focus': selectedResult === 'Visitor' }">
                                    <input type="radio" name="result" value="Visitor" id="option3" autocomplete="off"
                                        v-model="selectedResult"
                                        @click="handleClickOnResultOption"> Visitor
                                </label>
                            </div>
                            <div class="form-group">
                                <label for="visitorName1" class="sr-only">Email</label>
                                <input type="text" readonly class="form-control-plaintext text-left ml-2" id="visitorName1" value="Real Madrid">
                            </div>
                        </div>
                    </form>
                </div>
            </div>
            <div id="output"></div>
            <p id="counter"></p>
        </div>
    </div>
</template>

<script>
export default {
  data: function() {
    return { selectedResult: null };
  },
  methods: {
    handleClickOnResultOption(event) {
      console.warn("Click on result!");
      console.warn("event", event);
      console.warn("selectedResult", this.selectedResult);
    }
  }
};
</script>

<style scoped>
.form-control-plaintext {
  background-color: aquamarine;
}
</style>

