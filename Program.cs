using MyMLApp;

while (true)
{
    Console.WriteLine("Digite sua frase, para identificarmos o humor dela.");
    var mensagem = Console.ReadLine();

    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = mensagem
    };

    var result = SentimentModel.Predict(sampleData);

    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
}