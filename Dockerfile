FROM microsoft/dotnet
RUN mkdir skidpdf
ADD ./ /skidpdf
RUN groupadd -r skidpdf && useradd -r -g skidpdf skidpdf
RUN cd skidpdf; dotnet restore;
CMD cd skidpdf; dotnet run --urls "http://*:5050"
