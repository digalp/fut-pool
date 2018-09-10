<template>
    <div id="app">
        <div class="container-fluid">
            <div class="jumbotron">
                <h1>FutPool</h1>
            </div>
            <div>
                <div>
                    <div>{{ selectedResult }}</div>
                    <div class="btn-group btn-group-justified btn-group-toggle">
                        <label class="btn btn-secondary" :class="{ 'active focus': selectedResult === 'Home' }">
                            <input type="radio" name="result" value="Home" id="option1" autocomplete="off"
                                v-model="selectedResult"
                                @click="handleClickOnResultOption"> Home
                        </label>
                        <label class="btn btn-secondary" :class="{'active focus': selectedResult === 'Tie' }">
                            <input type="radio" name="result" value="Tie" id="option2" autocomplete="off"
                                v-model="selectedResult"
                                @click="handleClickOnResultOption"> Tie
                        </label>
                        <label class="btn btn-secondary" :class="{ 'active focus': selectedResult === 'Visitor' }">
                            <input type="radio" name="result" value="Visitor" id="option3" autocomplete="off"
                                v-model="selectedResult"
                                @click="handleClickOnResultOption"> Visitor
                        </label>
                    </div>
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

<style>
</style>

