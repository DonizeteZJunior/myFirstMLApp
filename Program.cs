using MyMLApp;

while (true)
{
    Console.WriteLine("Digite sua frase, para identificarmos o humor dela: ");
    var mensagem = Console.ReadLine();

    /* Amazon ============ */
    var amazonData = new AmazonModel.ModelInput()
    {
        Col0 = mensagem
    };

    var resultAmazon = AmazonModel.Predict(amazonData);

    var sentimentAmazon = resultAmazon.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Amazon Sentiment: {sentimentAmazon} \n");

    /* IMDB ============== */
    var imdbData = new ImdbModel.ModelInput()
    {
        Col0 = mensagem
    };

    var sentimentIMDB = ImdbModel.Predict(imdbData);
    Console.WriteLine($"Amazon Sentiment: {sentimentIMDB} \n");

    /* Yelp ============== */
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = mensagem
    };

    var resultSentiment = SentimentModel.Predict(sampleData);

    var sentiment = resultSentiment.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Yelp Sentiment: {sentiment} \n");
}